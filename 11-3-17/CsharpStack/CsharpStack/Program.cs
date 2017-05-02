using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(10);
            myStack.Push(100);
            myStack.Push(1000);
            myStack.Push(200);

            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Pop());
           // Console.WriteLine(myStack.Peek());
            foreach (var test in myStack)
            {
              Console.WriteLine(test);  
            }

            Console.ReadKey();
        }
    }
}
