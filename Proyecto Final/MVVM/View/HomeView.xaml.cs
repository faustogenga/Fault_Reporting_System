using Proyecto_Final.src;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using Proyecto_Final.wpf;

namespace Proyecto_Final.MVVM.View
{
    public partial class HomeView : UserControl
    {

        const string selectLlenarTabla = "SELECT " +
                "id AS Tiquete," +
                "cedula_admin AS Administrador," +
                "Estado AS Estado," +
                "Tipo AS Tipo, " +
                "Severidad as Severidad FROM TIQUETE WHERE Estado = 'Abierto'";


        SqlConnection sqlConnection = new SqlConnection("Data Source=FAUSTOS-MSI\\MSSQLSERVER01;Initial Catalog=AveriasDB;Integrated Security=True");

        public HomeView()
        {
            InitializeComponent();
            llenarDataGrid(selectLlenarTabla);
        }
        

        private void solucionarClick(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=FAUSTOS-MSI\\MSSQLSERVER01;Initial Catalog=AveriasDB;Integrated Security=True");
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand
                ("UPDATE TIQUETE SET Estado = 'Solucionado' WHERE ID= " + NumTiqueteTextBlock.Text, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Tiquete solucionado");
            llenarDataGrid(selectLlenarTabla);

        }

        private void misAveriasClick(object sender, RoutedEventArgs e)
        {
            string query = "SELECT " +
                "id AS Tiquete," +
                "cedula_admin AS Administrador," +
                "Estado AS Estado," +
                "Tipo AS Tipo, " +
                "Severidad as Severidad FROM TIQUETE WHERE Estado = 'Abierto'";
            llenarDataGrid(query);

        }

        private void todasLasAveriasClick(object sender, RoutedEventArgs e)
        {

        }

        private void actualizarClick(object sender, RoutedEventArgs e)
        {
            llenarDataGrid(selectLlenarTabla);
        }

        private void llenarDataGrid(string query)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable("TIQUETE");
            dataAdapter.Fill(dataTable);

            TiquetesDataGrid.ItemsSource = dataTable.DefaultView;
            dataAdapter.Update(dataTable);
            sqlConnection.Close();
        }

        private void DataGridRow_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Get the data from the selected row
            DataRowView row = (DataRowView)TiquetesDataGrid.SelectedItem;
            string id = row["Tiquete"].ToString();

            string query = "SELECT " +
                "id AS Tiquete," +
                "cedula_usuario AS Usuario," +
                "cedula_admin AS Administrador," +
                "Asunto AS Asunto," +
                "Descripcion AS Descripcion," +
                "Estado AS Estado," +
                "Tipo AS Tipo, " +
                "Severidad as Severidad, fecha_creacion AS FechaCreacion " +
                "FROM TIQUETE WHERE ID = " + id;

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            // Get the data from the query and insert it into variables
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string id2 = reader["Tiquete"].ToString();
            string usuario = reader["Usuario"].ToString();
            string admin2 = reader["Administrador"].ToString();
            string asunto = reader["Asunto"].ToString();
            string descripcion = reader["Descripcion"].ToString();
            string estado2 = reader["Estado"].ToString();
            string tipo2 = reader["Tipo"].ToString();
            string severidad2 = reader["Severidad"].ToString();
            string fechaCreacion = reader["FechaCreacion"].ToString();
            sqlConnection.Close();
            NumTiqueteTextBlock.Text = id2;
            UsuarioTextBlock.Text = usuario;
            AdminTextBlock.Text = admin2;
            AsuntoTextBlock.Text = asunto;
            DescripcionTextBlock.Text = descripcion;
            EstadoTextBlock.Text = estado2;
            TipoTextBlock.Text = tipo2;
            SeveridadTextBlock.Text = severidad2;
            FechaCreacionTextBlock.Text = fechaCreacion;
            sqlConnection.Close();
        }
    }
}
