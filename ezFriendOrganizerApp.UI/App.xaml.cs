using ezFriendOrganizerApp.UI.DataService;
using ezFriendOrganizerApp.UI.ViewModel;
using System.Windows;

namespace ezFriendOrganizerApp.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindow(
                new MainViewModel(
                new FriendDataService())
            );
            mainWindow.Show();
        }
    }
}
