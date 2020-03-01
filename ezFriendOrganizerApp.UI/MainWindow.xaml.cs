using ezFriendOrganizerApp.UI.ViewModel;
using System.Windows;

namespace ezFriendOrganizerApp.UI
{    
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
            Loaded += MainWindow_Loded;
        }

        private void MainWindow_Loded(object sender, RoutedEventArgs e)
        {
            _viewModel.Load();
        }
    }
}
