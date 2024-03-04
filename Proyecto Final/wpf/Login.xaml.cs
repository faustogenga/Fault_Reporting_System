using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Data.SqlClient;
using Proyecto_Final.src;
using Proyecto_Final.MVVM.View;

namespace Proyecto_Final.wpf
{
    public partial class Login : Window
    {
        public string DefaultText { get; set; }
        static Persona persona { get; set; }
        

        public Login()
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

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            

            // get the email and password from the textboxes
            string email = CorreoTextBox.Text;
            string password = PassTextBox.Password;
            // validate with the database if the user exists
            SqlConnection sqlConnection = new SqlConnection("Data Source=FAUSTOS-MSI\\MSSQLSERVER01;Initial Catalog=AveriasDB;Integrated Security=True");
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand
                ("SELECT Correo, Password FROM USUARIO WHERE Correo = @correo AND password = @password", sqlConnection);

            SqlCommand cmd2 = new SqlCommand
               ("SELECT cedula FROM USUARIO WHERE Correo = @correo AND password = @password", sqlConnection);


            cmd.Parameters.AddWithValue("@correo", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd2.Parameters.AddWithValue("@correo", email);
            cmd2.Parameters.AddWithValue("@password", password);

            cmd.ExecuteNonQuery();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    nuevaAveriaView.cedulausuario = (long)(cmd2.ExecuteScalar());
                    MessageBox.Show("Bienvenido", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                    ClienteMainWindow clientMain = new ClienteMainWindow();
                    Close();
                    clientMain.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos","Message", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void Button_LoginAdmin_Click(object sender, RoutedEventArgs e)
        {
            // get the email and password from the textboxes
            string email = CorreoTextBox.Text;
            string password = PassTextBox.Password;
            // validate with the database if the user exists
            SqlConnection sqlConnection = new SqlConnection("Data Source=FAUSTOS-MSI\\MSSQLSERVER01;Initial Catalog=AveriasDB;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand
                ("SELECT Correo, Password FROM ADMINISTRADOR WHERE Correo = @correo AND password = @password", sqlConnection);

            cmd.Parameters.AddWithValue("@correo", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Bienvenido", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                    AdminMainWindow adminMain = new AdminMainWindow();
                    adminMain.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void Register_Button_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            Close();
            register.Show();
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            DefaultText = box.Text;
            box.Text = box.Text == DefaultText ? string.Empty : box.Text;
        }
        public void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.Text = box.Text == string.Empty ? DefaultText : box.Text;
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

    }
}
