using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWishlist.User
{
    public class UserDatabase
    {
        private static UserDatabase _instance;

        private static readonly object _lock = new object();

        private List<User> _database = new List<User>
        {
            new User("TestUser1"),
            new User("TestUser2"),
            new User("TestUser3")
        };

        public static UserDatabase GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance = new UserDatabase();
                    }
                }
                return _instance;
            }
        }

        public bool CheckPrivileges(User user)
        {
            return _database.Exists(obj => obj.ID == user.ID);
        }
    }
}
