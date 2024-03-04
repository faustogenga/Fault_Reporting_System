using Proyecto_Final.Core;

namespace Proyecto_Final.MVVM.ViewModel
{
    class ClienteMainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand NuevaAveriaViewCommand { get; set; }
        public RelayCommand MisAveriasViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }
        public nuevaAveriaViewModel NuevaAveriaVm { get; set; }
        public misAveriasViewModel MisAveriasVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            
            set { _currentView = value; OnPropertyChanged(); }
        }


        public ClienteMainViewModel()
        {
            HomeVm = new HomeViewModel();
            NuevaAveriaVm = new nuevaAveriaViewModel();
            MisAveriasVm = new misAveriasViewModel();
            
            CurrentView = NuevaAveriaVm;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = NuevaAveriaVm;
            });

            NuevaAveriaViewCommand = new RelayCommand(o =>
            {
                CurrentView = NuevaAveriaVm;
            });

            MisAveriasViewCommand = new RelayCommand(o =>
            {
                CurrentView = MisAveriasVm;
            });
        }
        
    }
    
}
