using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Persons = new List<Person>();
            Person p = new Person();
            p.FirstName = "Mohon";
            p.LastName = "Khan";

            Person p2 = new Person();
            p2.FirstName = "Julhas";
            p2.LastName = "Hossian";

            Person p3 = new Person();
            p3.FirstName = "Eyamin";
            p3.LastName = "Khan";

            Persons.Add(p);
            Persons.Add(p2);
            Persons.Add(p3);

            foreach (Person aperson in Persons)
            {
                Console.WriteLine(aperson.FirstName+ " "+ aperson.LastName);
            }

            //string a = p.FirstName;
            //Console.WriteLine(p.FirstName+" "+p.LastName);
            //Console.WriteLine(p.GetFullName());
            //Console.WriteLine(p.GetFullName(p.FirstName,p.LastName));
            //Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
