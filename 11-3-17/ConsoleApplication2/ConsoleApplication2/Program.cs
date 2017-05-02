using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList= new ArrayList();
            myArrayList.Add(10.12);
            myArrayList.Add("abc");
            myArrayList.Add(100);
            myArrayList.Add(20.5);
            foreach (var test in myArrayList)
            {
               Console.WriteLine(test); 
            }
            ArrayList newList= new ArrayList();
            newList.Add(5.5);
            newList.Add("BITM");
            myArrayList.AddRange(newList);
            Console.WriteLine(myArrayList.Count);
            myArrayList.Remove(100);

            Console.ReadKey();
        }
    }
}
