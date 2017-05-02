using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryProblemSolve
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] value1 = { "BMW", "Ferrari", "Audi" };

            //Dictionary<int, string[]> myDictionary = new Dictionary<int, string[]>();
            //myDictionary.Add(1, value1);
            ////myDictionary.Add(2, "BITM");
            ////myDictionary.Add(3, "TEST");
            ////myDictionary.Add(4, "ABC");

            //foreach (KeyValuePair<int, string[]> keyValuePair in myDictionary)
            //{
                
            //    Console.WriteLine(keyValuePair.Key + " - " + keyValuePair.Value[0]);
            //    Console.WriteLine(keyValuePair.Key + " - " + keyValuePair.Value[1]);
            //    Console.WriteLine(keyValuePair.Key + " - " + keyValuePair.Value[2]);
                
            //}

            //Dictionary<string,int[]> myDictionary = new Dictionary<string, int[]> {{"length", new int[]{1,2}},{ "width",new int[]{3,4}}};
            //myDictionary

            //foreach(KeyValuePair<int,List<string>> dicItem in crs.DocDictionary)
            //{
            //    foreach(string entry in dicItem.Value)
            //    {
            //        Console.WriteLine("Current entry for list {0}: {1}", dicItem.Key, entry);
            //    }
            //}

            Dictionary<int, string[]> myDictionary = new Dictionary<int, string[]>();
            myDictionary.Add(1,new string[]{"abc","def","ert"});
            myDictionary.Add(2,new string[]{"BMW","Audi","Ferrari"});
            myDictionary.Add(3,new string[]{"Bangla","english","Math"});

            foreach (KeyValuePair<int, string[]> pair in myDictionary)
            {
                Console.WriteLine("key Value : ");
                foreach (var test in pair.Value)
                {
                    Console.WriteLine("Value is :" +test);
                }
            }

            Console.ReadKey();


           // name                    type             size
           //Array                  fixed              fixed
            //ArrayList             Dynamic             dynamic
            //List                  fixed               dynamic
            //Stack                 fixed               dynamic
            //Queue                 fixed               dynamic
            //hashtable             dynamic             dynamic
            //Dictionary            Fixed               dynamic
        }
    }
}
