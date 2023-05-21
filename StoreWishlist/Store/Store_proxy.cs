using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWishlist.Store
{
    class Store_proxy : IStore
    {
        private IStore _store = null;
        private User.UserDatabase _authorizedUsers = User.UserDatabase.GetInstance;

        public void GetInstance()
        {
            _store = Store.GetInstance;
        }

        public void WishlistItem(User.User user, String itemName)
        {
            if (!_authorizedUsers.CheckPrivileges(user))
            {
                Console.WriteLine(user.ID + " is not a registered user!");
                return;
            }

            _store.WishlistItem(user, itemName);
        }
        public void ModifyPrice(String itemName, int newPrice)
        {
            _store.ModifyPrice(itemName, newPrice);
        }
    }
}
