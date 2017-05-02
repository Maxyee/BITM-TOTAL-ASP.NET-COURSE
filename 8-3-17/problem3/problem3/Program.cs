using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                else if (i % 5 == 0)
                {
                   Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

    }
}
