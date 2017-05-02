using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_even
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");

            i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }

                //int i;
                //Console.Write("Enter a Number : ");
                //i = Convert.ToInt32(Console.ReadLine());
                
                //for (int j = 0; j <= i; j++)
                //{
                //    if (i % 2 == 0)
                //    {
                //        Console.Write(j+"Entered Number is an Even Number");
                //        Console.Read();
                //    }
                //    else
                //    {
                //        Console.Write(j+"Entered Number is an Odd Number");
                //        Console.Read();
                //    }
                //}

            }
        }
}

