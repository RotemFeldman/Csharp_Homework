using System.ComponentModel;

namespace LimitedObservableList
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            bool ContainsS(string s)
            {
                s.ToLower();
                return s.Contains("s");
            }

            Predicate<string> Predicate = ContainsS;

            var limitedObservableList = new LimitedObservableList(Predicate);

            limitedObservableList.TryAdd("salad");
            limitedObservableList.TryAdd("lisbon");
            limitedObservableList.TryAdd("orangutang");
            limitedObservableList.TryAdd("computer");
            limitedObservableList.TryAdd("plaster");
            limitedObservableList.TryAdd("wood");
            limitedObservableList.TryAdd("evening");
            limitedObservableList.TryAdd("glue");
            limitedObservableList.TryAdd("hard drive");
            limitedObservableList.TryAdd("empty");

            limitedObservableList.PrintAll();
            
        }
    }
}
