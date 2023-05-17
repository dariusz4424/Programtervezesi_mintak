using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whislist_Programtervezési_mintak
{
    public class Item : IItem
    {
        private string _name;
        private int _price;
        private List<IUser> _observers;

        public Item(string name, int price)
        {
            _name = name;
            _price = price;
            _observers = new List<IUser>();
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

        public void RegisterObserver(IUser observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(IUser observer)
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
