using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 10;
         
            int total;

            for (int k = i; k <= j; k++)
            {
                total = k*k;
                //total = total + k;
                Console.WriteLine(total);
                
            }

            for (int k = i; k < j; k++)
            {
                total = (k*k + 1)*(k*k + 1);
                Console.WriteLine(total);
            }
            //Console.WriteLine(Convert.ToInt32(shortcut));
            Console.ReadKey();
            
        }
    }
}
