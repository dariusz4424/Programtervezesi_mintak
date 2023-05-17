using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whislist_Programtervezési_mintak
{
    public interface IWishlist
    {
        void AddItem(User user, Item item);
    }
}
