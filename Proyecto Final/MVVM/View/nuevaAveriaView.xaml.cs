using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Proyecto_Final.MVVM.View
{
    /// <summary>
    /// Interaction logic for nuevaAveriaView.xaml
    /// </summary>
    public partial class nuevaAveriaView : UserControl
    {
        public static long cedulausuario = 0;

        DateTime FechaCreacion = DateTime.Now;
        public nuevaAveriaView()
        {
            InitializeComponent();
        }

        private void enviarClick(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=FAUSTOS-MSI\\MSSQLSERVER01;Initial Catalog=AveriasDB;Integrated Security=True");
            sqlConnection.Open();
            Regex cedulas = new Regex(@"^\d+$");

            string cedula = "select cedula from administrador";
            SqlCommand sqlcommand = new SqlCommand(cedula, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcommand);
            DataTable testTable;

            using (sqlDataAdapter)
            {
                testTable = new DataTable();
                sqlDataAdapter.Fill(testTable);
            }
            var arlist = new ArrayList();

            foreach (DataRow row in testTable.Rows)
            {
                arlist.Add(row["cedula"]);
            }
            Random rnd = new();

            long CedulaAdmin = (long)arlist[rnd.Next(arlist.Count)];

            string EstadoTiquete = "Abierto";

            SqlCommand cmd = new SqlCommand
                (
                "INSERT INTO TIQUETE " +
                "(cedula_usuario, cedula_admin, Asunto, Descripcion, Estado, Tipo, Severidad, fecha_creacion) " +
                "VALUES " +
                "(@cedula_usuario, @cedula_admin, @Asunto, @Descripcion, @Estado, @Tipo, @Severidad, @fecha_creacion);",
                sqlConnection
                );

            if (TextBoxAsunto.Text.Trim() == "" || TextBoxDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Debe llenar todos los campos ", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else 
            {
             
            cmd.Parameters.AddWithValue("@cedula_usuario", cedulausuario);
            cmd.Parameters.AddWithValue("@cedula_admin", CedulaAdmin);
            cmd.Parameters.AddWithValue("@Asunto", TextBoxAsunto.Text);
            cmd.Parameters.AddWithValue("@Descripcion", TextBoxDescripcion.Text);
            cmd.Parameters.AddWithValue("@Estado", EstadoTiquete);
            cmd.Parameters.AddWithValue("@Tipo", ComboBoxTipo.Text);
            cmd.Parameters.AddWithValue("@Severidad", ComboBoxSeveridad.Text);
            cmd.Parameters.AddWithValue("@fecha_creacion", DateTime.Today);

            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Tiquete agregado correctamente", "Message", MessageBoxButton.OK, MessageBoxImage.Information );

            }
        }

        private void cancelarClick(object sender, RoutedEventArgs e)
        {
            TextBoxDescripcion.Text = "";
            TextBoxAsunto.Text = "";
            
            MessageBox.Show("Tiquete cancelado");
        }

        private void verificarExistenciaDeTiquete()
        {
            
        }

    }
}
