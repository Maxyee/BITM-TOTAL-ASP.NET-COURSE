using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem5
{

    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Accept number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0 || num1 == 1)
            {
                Console.WriteLine(num1 + " is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= num1 / 2; a++)
                {
                    if (num1 % a == 0)
                    {
                        Console.WriteLine(num1 + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(num1 + " is a prime number");
                Console.ReadLine();
            }
            Console.ReadKey();


        }
    }
}
