using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Proyecto_Final.MVVM.View;

namespace Proyecto_Final.wpf
{
    public partial class AdminMainWindow : INotifyPropertyChanged
    {
        public AdminMainWindow()
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

        private void MisAveriasClick(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
