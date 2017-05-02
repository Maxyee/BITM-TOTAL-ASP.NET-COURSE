using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person("julhas", "hossain", "mohon");
            aPerson.firstname = "Niamul";
            aPerson.middlename = "Islam";
            aPerson.lastname = "shimul";
            string fullname = aPerson.GetFullName();
            string reverName = aPerson.GetReverseName(fullname);
            Console.WriteLine(fullname);
            Console.WriteLine(reverName);

            Person person2 = new Person("Eyamin","Khan","Mohon");
            person2.firstname = "Rokibul";
            person2.middlename = "Hasan";
            person2.lastname = "Nahid";

            fullname = person2.GetFullName();
            reverName = person2.GetReverseName(fullname);
            Console.WriteLine(fullname);
            Console.WriteLine(reverName);

            Person person3;
            person3 = person2;
            person3.firstname = "tushi";
            //person2 = null;

            Person person4 = new Person("mohon","khan");
            Person person5 = new Person();
            person5.id = "160528";

            Console.ReadKey();
        }
    }
}
