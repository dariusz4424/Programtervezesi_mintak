using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWishlist.Store
{
    public interface IStore
    {
        void WishlistItem(User.User user, String itemName);
        void ModifyPrice(String itemName, int _newPrice);
    }
}
