using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHidingAndProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aperson = new Person();
            aperson.FirstName = "Mohon";
            aperson.SetMiddleName("khan");
            aperson.LastName = "Maxyee";

            Console.WriteLine("FirstName: "+ aperson.FirstName + "\n MiddleName: "+aperson.GetMiddleName()+"\n LastName: "+aperson.LastName);
            Console.ReadKey();
        }
    }
}
