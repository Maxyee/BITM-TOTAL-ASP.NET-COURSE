using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee t1 = new Trainee();
            t1.firstName = "eyamin";
            t1.lastName = "Khan";
            Trainee.batchNumber = "forty two :: 42";

            Console.WriteLine(t1.firstName);
            Console.WriteLine(t1.lastName);
            Console.WriteLine(Trainee.batchNumber);

            Console.ReadKey();
        }
    }
}
