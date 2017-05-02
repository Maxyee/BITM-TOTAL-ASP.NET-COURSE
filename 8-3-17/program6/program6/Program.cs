using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 32;
            int num2 = 40;
            int num3 = 10;

            if (num1>=num2 && num1>=num3)
            {
                Console.WriteLine("biggest number is : " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("biggest number is : " + num2);
            }
            else if (num3 >= num2 && num3 >= num1)
            {
                Console.WriteLine("biggest number is : " + num3);
            }
            Console.ReadKey();
            
        }
    }
}
