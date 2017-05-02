using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new[] {2, 45, 10, 5};
            foreach (int test in myarray)
            {
            Console.WriteLine(test);    
            }
            Console.ReadKey();
        }
    }
}
