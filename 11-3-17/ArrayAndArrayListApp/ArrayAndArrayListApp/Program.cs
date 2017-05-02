using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                5,10,12,50,55
            };

            for (int i = 0; i < numbers.Length ; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("ArrayList OOP start From Here");
            
            ArrayList myList = new ArrayList();
            myList.Add(12);
            myList.Add(12.5);
            myList.Add("test");
            myList.Add("");

            foreach (var list in myList)
            {
                Console.WriteLine(list);
            }

            int a = myList.Count;
            Console.WriteLine("List Length is " + a);
            myList.RemoveAt(2);
            a = myList.Count;
            Console.WriteLine("List Length is "+a);
            foreach (var list in myList)
            {
                Console.WriteLine(list);
            }

            ArrayList myList2 = new ArrayList();
            myList2.Add(100);
            myList2.Add("abc");
            myList2.Add(105.5);
            myList.AddRange(myList2);

            foreach (var test in myList)
            {
                Console.WriteLine(test);
            }


            //List<int> newList = new List<int>();

            Console.ReadKey();
        }
    }
}
