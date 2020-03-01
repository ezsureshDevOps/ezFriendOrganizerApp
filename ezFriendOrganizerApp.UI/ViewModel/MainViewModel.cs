using ezFriendOrganizerApp.Model;
using ezFriendOrganizerApp.UI.DataService;
using System.Collections.ObjectModel;

namespace ezFriendOrganizerApp.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IFriendDataService _friendDataService;

        private Friend _selectedFriend;        

        public MainViewModel(IFriendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            _friendDataService = friendDataService;
        }

        public void Load()
        {
            var friends = _friendDataService.GetAll();

            Friends.Clear();

            foreach(var friend in friends)
            {
                Friends.Add(friend);
            }
        }

        public ObservableCollection<Friend> Friends { get; set; }

        

        #pragma warning disable S2292 // Trivial properties should be auto-implemented
        public Friend SelectedFriend
        #pragma warning restore S2292 // Trivial properties should be auto-implemented
        {
            get { return _selectedFriend; }
            set 
            { 
                _selectedFriend = value;
                OnPropertyChanged();
            }            
        }
    }
}
