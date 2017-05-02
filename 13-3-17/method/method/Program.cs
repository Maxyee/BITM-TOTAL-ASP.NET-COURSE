using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 int number separtrating by pressing 'Enter': ");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            int secoundnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition result is "+ add(firstnumber,secoundnumber));
            Console.WriteLine("Substract result is " + sub(firstnumber, secoundnumber));
            Console.ReadKey();
        }

        static int add(int x, int y)
        {
            int result = x + y;
            return result;
        }

        static int sub(int x, int y)
        {
            int result = x - y;
            return result;
        }
    }
}
