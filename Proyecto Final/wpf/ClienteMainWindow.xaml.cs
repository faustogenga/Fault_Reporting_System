using System.Windows;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Proyecto_Final.wpf;

namespace Proyecto_Final
{
    public partial class ClienteMainWindow : INotifyPropertyChanged
    {
        public ClienteMainWindow()
        {
            DataContext = this;
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

        private void CerrarSesion_Button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new();
            Close();
            login.Show();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
