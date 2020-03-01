using ezFriendOrganizerApp.Model;
using System.Collections.Generic;

namespace ezFriendOrganizerApp.UI.DataService
{
    public interface IFriendDataService
    {
        IEnumerable<Friend> GetAll();
    }
}