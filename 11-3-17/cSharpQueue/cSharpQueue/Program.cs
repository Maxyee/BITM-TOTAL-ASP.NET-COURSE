using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> aQueue = new Queue<int>();
            aQueue.Enqueue(10);
            aQueue.Enqueue(200);
            aQueue.Enqueue(150);
            foreach (var test in aQueue)
            {
                Console.WriteLine(test);
            }

           // Console.WriteLine(aQueue.Dequeue());
            //Console.WriteLine(aQueue.Dequeue());
            //Console.WriteLine(aQueue.Dequeue());

            Console.ReadKey();
        }
    }
}
