using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whislist_Programtervezési_mintak
{
    class Wishlist : IWishlist
    {
        private static Wishlist _instance;

        //szálbiztossághoz
        private static readonly object _lock = new object();

        private List<Item> kívánságok = new List<Item>();


        //GetInstance definiálása Singletonhoz
        public static Wishlist GetInstance { 
            get 
            { 
                if (_instance == null) 
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Wishlist();
                        }
                    }
                }
                return _instance;
            } 
        }

        //Item hozzáadása
        public void AddItem(User user, Item item)
        {
            kívánságok.Add(item);
            item.RegisterObserver(user);
        }
    }
}
