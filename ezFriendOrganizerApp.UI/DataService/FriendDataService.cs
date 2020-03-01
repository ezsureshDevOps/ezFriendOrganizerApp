using ezFriendOrganizerApp.Model;
using System.Collections.Generic;

namespace ezFriendOrganizerApp.UI.DataService
{
    public class FriendDataService : IFriendDataService
    {
        public FriendDataService()
        {
        }

        public IEnumerable<Friend> GetAll()
        {
            // Load data from real database
            yield return new Friend { FirstName = "Suresh", LastName = "Chhatwani" };
            yield return new Friend { FirstName = "Abhishek", LastName = "Shah" };
            yield return new Friend { FirstName = "Harish", LastName = "Shah" };
            yield return new Friend { FirstName = "Rajiv", LastName = "Shah" };
        }
    }
}