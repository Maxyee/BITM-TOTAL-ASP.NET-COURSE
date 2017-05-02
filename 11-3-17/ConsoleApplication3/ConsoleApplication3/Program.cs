using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num= new double[5];
            double sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
              Console.WriteLine("enter number"+ (i+1).ToString());
                num[i] = Convert.ToDouble(Console.ReadLine());
                sum += num[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
