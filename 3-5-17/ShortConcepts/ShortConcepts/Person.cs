using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShortConcepts
{
    public class Person
    {
        static void Main(string[] args)
        {
            var aCustomer = new {Name = "Rumki", Id = 09817, Address = "Chittagong"};

            string n = aCustomer.Name;
            int price = aCustomer.Id;

            Console.WriteLine(aCustomer.Name);

            var names = new[] {"Kaniz", "Zamil", "Rumpa"};
        }
    }
}