using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whislist_Programtervezési_mintak
{
    public class User : IUser
    {
        private string _ID;
        public User(string ID)
        {
            _ID = ID;
        }

        public string ID { get { return _ID; } }

        public void Update(Item item)
        {
            Console.WriteLine($"{item.Name} is on sale! Be sure to hurry up, not to miss it!");
        }
    }
}
