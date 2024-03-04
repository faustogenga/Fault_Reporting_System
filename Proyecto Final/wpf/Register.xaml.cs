using Proyecto_Final.src;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace Proyecto_Final.wpf
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {

        public string DefaultText { get; set; }
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-VCL3B8P\\SQLSERVER2019;Initial Catalog=ReportesDeAverias;Integrated Security=True");

        public Register()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Register_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=FAUSTOS-MSI\\MSSQLSERVER01;Initial Catalog=AveriasDB;Integrated Security=True");

            Regex correos = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match correo = correos.Match(Textboxcorreo.Text);

            Regex cedulas = new Regex(@"^\d+$");
            Match cedula = cedulas.Match(Textboxcedula.Text);


            if (Textboxapellido.Text == "Apellido" || Textboxcedula.Text == "Cedula" || Textboxname.Text == "Nombre"
                || Textboxapellido.Text.Trim() == "" || Textboxcedula.Text.Trim() == "" || Textboxname.Text.Trim() == "")
            { 
                MessageBox.Show("Debe llenar todos los campos ", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                Textboxname.Focus();
            }
            else if (!cedula.Success)
            {
                MessageBox.Show("Cedula incorrecta", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!correo.Success)
            {
                MessageBox.Show("Ingrese un correo valido.", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                Textboxcorreo.Focus();
            }
            else
            {
                string checkemail = "SELECT correo FROM USUARIO where correo = @correo" +
                    " UNION " +
                    "SELECT correo FROM ADMINISTRADOR where correo = @correo";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(checkemail, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@correo", Textboxcorreo.Text.Trim());
                sqlCommand.ExecuteNonQuery();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Correo ya esta registrado", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                    Textboxcorreo.Focus();
                    sqlConnection.Close();
                }
                else
                {
                    sqlConnection.Close();
                    if (Textboxpass1.Password.ToString() == "password" || Textboxpass2.Password.ToString() == "password")
                    {
                        MessageBox.Show("Ingrese contraseña", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                        Textboxpass1.Focus();
                    }
                    else if (Textboxpass1.Password.ToString() != Textboxpass2.Password.ToString())
                    {
                        MessageBox.Show("Contraseñas no conciden", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                        Textboxpass1.Focus();
                        Textboxpass2.Focus();
                    }
                    else
                    {
                        sqlConnection.Open();
                        string insert = "INSERT INTO USUARIO " +
                        "(Cedula,Nombre,Apellido,Correo,Password) " +
                        "VALUES (@cedula,@nombre,@apellido,@correo,@password)";

                        SqlCommand sqlCommand2 = new SqlCommand(insert, sqlConnection);
                        
                        sqlCommand2.Parameters.AddWithValue("@cedula", long.Parse(Textboxcedula.Text.Trim()));
                        sqlCommand2.Parameters.AddWithValue("@nombre", Textboxname.Text.Trim());
                        sqlCommand2.Parameters.AddWithValue("@apellido", Textboxapellido.Text.Trim());
                        sqlCommand2.Parameters.AddWithValue("@correo", Textboxcorreo.Text.Trim());
                        sqlCommand2.Parameters.AddWithValue("@password", Textboxpass1.Password);
                        sqlCommand2.ExecuteScalar();
                        MessageBox.Show("Registrado correctamente", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                        sqlConnection.Close();
                        Login login = new();
                        Close();
                        login.Show();
                    }
                }
            }
        }
        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new();
            Close();
            login.Show();
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            DefaultText = box.Text;
            if (box.Text == "Nombre" || box.Text == "Apellido" || box.Text == "Cedula" || box.Text == "Correo")
            {
                box.Text = string.Empty;
            }
        }

        public void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            if  (DefaultText == "Nombre" || DefaultText == "Apellido" || DefaultText == "Cedula" || DefaultText == "Correo")
            {
                box.Text = box.Text == string.Empty ? DefaultText : box.Text;
            }

        }

        public void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox box = (PasswordBox)sender;
            DefaultText = box.Password;
            box.Password = box.Password == DefaultText ? string.Empty : box.Password;
        }
        public void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox box = (PasswordBox)sender;
            box.Password = box.Password == string.Empty ? DefaultText : box.Password;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Textboxcedula_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
