//  C#II (Dor Ben Dor)  //
//     Rotem Feldman    //
//////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LimitedObservableList
{
    public class LimitedObservableList
    {
        public event ListChanged? OnListChanged;
        public delegate string ListChanged (object sender, string changeMade);

        private ListChanged listChangedDelegate;

        private Predicate<string> _predicate;
        private List<string> _list = new List<string>();

        public LimitedObservableList(Predicate<string> predicate)
        {
            _predicate = predicate;           
            listChangedDelegate += NotifyOnDelegateCall;
        }

        public bool TryAdd(string item)
        {
            if(_predicate(item))
            {
                _list.Add(item);
                OnListChanged?.Invoke(this, item);
                listChangedDelegate?.Invoke(this, item);
                return true;
            }

            return false;
        }

        public void PrintAll()
        {
            foreach(var item in _list)
            {
                Console.WriteLine(item);
            }
        }

        private string NotifyOnDelegateCall(object sender, string changeMade)
        {
            Console.WriteLine("listChangedDelegate called");
            
            return changeMade;
        }

        
    }

}
