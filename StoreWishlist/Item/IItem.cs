using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWishlist.Item
{
    public interface IItem
    {
        void RegisterObserver(User.IUser observer);
        void UnregisterObserver(User.IUser observer);
        void NotifyObservers();
    }
}
