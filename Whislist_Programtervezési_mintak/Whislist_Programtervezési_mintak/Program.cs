using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whislist_Programtervezési_mintak
{
    class Program
    {
        static void Main(string[] args)
        {
            Wishlist_proxy kívánságListaProxy = new Wishlist_proxy();
                        
            //kívánság lista létrejön
            Wishlist kívánságLista = Wishlist.GetInstance;

            //bejelentkezés szimulálása
            User user1 = new User("exampleID");

            //Csatlakozás megkísérlése
            if (!kívánságListaProxy.Csatlakozas(user1, kívánságLista))
            {
                Console.WriteLine("Csatlakozás sikertelen");
            }


            //Áruház adatbázisának szimulálása
            List<Item> store = new List<Item>();
            store.Add(new Item("CS:GO", 29));
            store.Add(new Item("Call of Duty", 59));
            store.Add(new Item("Peggle", 9));
            store.Add(new Item("Super Mario", 15));
            store.Add(new Item("World of Warcraft", 38));

            //Termékek kívánság listához adása
            kívánságListaProxy.AddItem(user1, store[0]);
            kívánságListaProxy.AddItem(user1, store[1]);
            kívánságListaProxy.AddItem(user1, store[3]);
            kívánságListaProxy.AddItem(user1, store[4]);

            //Különböző termékek árának módosítása
            store[0].Price = 19;
            store[1].Price = 49;
            store[2].Price = 5;
            store[4].Price = 59;


            Console.ReadKey();
        }
    }
}
