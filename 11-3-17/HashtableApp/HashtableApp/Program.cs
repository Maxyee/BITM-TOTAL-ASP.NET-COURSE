using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashtable = new Hashtable();
            myHashtable.Add(1,"BITM");
            myHashtable.Add("2A",101);
            myHashtable.Add(2,200);
            myHashtable[3] = 500;

            Console.WriteLine(myHashtable[3]);
            Console.WriteLine(myHashtable[1]);
            Console.WriteLine(myHashtable["2A"]);
            Console.WriteLine(myHashtable.ContainsKey("2A"));
            Console.WriteLine(myHashtable.ContainsValue("BITM"));

            foreach (DictionaryEntry entry in myHashtable)
            {
                Console.WriteLine(entry.Key+" - "+entry.Value);
            }

            Console.ReadKey();
        }
    }
}
