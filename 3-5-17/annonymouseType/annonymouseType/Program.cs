using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace annonymouseType
{
    class Program
    {
        static void Main(string[] args)
        {
            var aCustomer = new {name = "Mohon", address = "Hello", id = 14144};

            string n = aCustomer.name;

            Console.WriteLine(aCustomer.name);
            Console.ReadKey();
        }
    }
}
