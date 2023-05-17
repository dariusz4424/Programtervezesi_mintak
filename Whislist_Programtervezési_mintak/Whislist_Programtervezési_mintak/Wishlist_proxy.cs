using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whislist_Programtervezési_mintak
{
    class Wishlist_proxy : IWishlist
    {
        private IWishlist _wishlist = null;

        //Csatlakozás kívánságlistához, ha megfelel a user ID
        public bool Csatlakozas(User user, Wishlist wishlist)
        {
            if(user.ID == "exampleID")
            {
                _wishlist = wishlist;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Item hozzáadása
        public void AddItem(User user, Item item)
        {
            if(_wishlist!=null)
            {
                SavingCookies_etc();
                _wishlist.AddItem(user, item);
            }
            else
            {
                Console.WriteLine("Kérem lépjen be a megfelelő felhasználóval");
            }
        }

        private void SavingCookies_etc()
        { }
    }
}
