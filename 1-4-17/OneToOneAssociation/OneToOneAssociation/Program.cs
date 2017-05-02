using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneAssociation
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address();

            address1.AptNo = "3c";
            address1.HouseNo = "39/4";
            address1.RoadNo = "West Tejturi bazar";
            address1.Thana = "tejgao";
            address1.District = "Dhaka";

            Person person1 = new Person("Jannatul", "Ferdus", "tushi");
            person1.PersonAddress = address1;

            Console.WriteLine(person1.PersonAddress.AptNo);

            //Address ads1;
            //ads1 = address1;
            //ads1.AptNo = "032";
            //ads1 = null;
            ////Console.WriteLine(ads1.AptNo);
            //Person personA = new Person("Eyamin", "Khan", "Mohon");
            //personA.PersonAddress = address1;
            //Console.WriteLine(personA.PersonAddress.AptNo);
            //Console.WriteLine("PersonA thana: " + personA.PersonAddress.Thana);



            //Console.WriteLine(personA.ads1);
            

            string fullName = person1.GetFullName();
            string reverseName = person1.GetReverseName();
            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);
            Console.WriteLine(person1.GetSalary());

            Person person2 = new Person("Julhas","Hossain","Mohon");

            fullName = person2.GetFullName();
            reverseName = person2.GetFullName();

            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);

            Console.ReadKey();
        }
    }
}
