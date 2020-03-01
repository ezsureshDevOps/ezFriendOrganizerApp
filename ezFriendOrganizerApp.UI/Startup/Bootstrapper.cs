using Autofac;
using ezFriendOrganizerApp.UI.DataService;
using ezFriendOrganizerApp.UI.ViewModel;

namespace ezFriendOrganizerApp.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<FriendDataService>().As<IFriendDataService>();

            return builder.Build();
        }
    }
}
