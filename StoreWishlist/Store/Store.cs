using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWishlist.Store
{
    class Store : IStore
    {
        private static Store _instance;

        //szálbiztossághoz
        private static readonly object _lock = new object();

        private List<Item.Item> _itemStore = new List<Item.Item> 
        {
            new Item.Item("CS:GO", 29),
            new Item.Item("Call of Duty", 59),
            new Item.Item("Peggle", 9),
            new Item.Item("Super Mario", 15),
            new Item.Item("World of Warcraft", 38)
        };

        //GetInstance definiálása Singletonhoz
        public static Store GetInstance
        {
            get
            {
                if(_instance == null)
                {
                    lock (_lock)
                    {
                        _instance = new Store();
                    }
                }
                return _instance;
            }
        }

        public void WishlistItem(User.User user, String itemName)
        {
            Item.Item _itemToWishlist = _itemStore.Find(obj => obj.Name == itemName);
            _itemToWishlist.RegisterObserver(user);
        }

        public void ModifyPrice(String itemName, int _newPrice)
        {
            Item.Item _itemToModify = _itemStore.Find(obj => obj.Name == itemName);
            _itemToModify.Price = _newPrice;
        }
    }
}
