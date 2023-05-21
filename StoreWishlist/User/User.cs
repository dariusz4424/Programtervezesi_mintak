using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWishlist.User
{
    public class User : IUser
    {
        private string _ID;
        public User(string ID)
        {
            _ID = ID;
        }

        public string ID { get { return _ID; } }

        public void Update(Item.Item item)
        {
            Console.WriteLine(_ID + ", " + item.Name + " is on sale! Be sure to hurry up, not to miss it!");
        }
    }
}
