using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicthonaryCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1,"ABC");
            myDictionary.Add(2,"BITM");
            myDictionary.Add(3,"TEST");
            myDictionary.Add(4,"ABC");

            foreach (KeyValuePair<int, string> keyValuePair in myDictionary)
            {
                Console.WriteLine(keyValuePair.Key+" - "+keyValuePair.Value);
            }

            Console.ReadKey();
        }
    }
}
