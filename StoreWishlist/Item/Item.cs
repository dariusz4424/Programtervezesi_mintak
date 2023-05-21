using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWishlist.Item
{
    public class Item : IItem
    {
        private string _name;
        private int _price;
        private List<User.IUser> _observers;

        public Item(string name, int price)
        {
            _name = name;
            _price = price;
            _observers = new List<User.IUser>();
        }

        public string Name { get { return _name; } }

        public int Price
        {
            get { return _price; }
            set
            {
                if (_price > value)
                {
                    NotifyObservers();
                }
                _price = value;
            }
        }

        public void RegisterObserver(User.IUser observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(User.IUser observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
