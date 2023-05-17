using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whislist_Programtervezési_mintak
{
    public interface IItem
    {
        void RegisterObserver(IUser observer);
        void UnregisterObserver(IUser observer);
        void NotifyObservers();

    }
}
