using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            var trainee = new[]
            {
                new { id = 1, name="Mohon", seid = 160528},
                new { id = 2, name= "Julhas", seid = 123452},
                new { id = 3, name= "eyamin", seid = 1238782},
                new { id = 4, name= "tasnim", seid = 123452}
            };

            show(trainee);

            Console.ReadKey();
        }

        private static void show(IEnumerable<dynamic> trainee)
        {
            foreach (var atraine in trainee)
            {
                Console.WriteLine("Id: "+ atraine.id+" Name: "+atraine.name+"seid : "+atraine.seid );
            }
        }


    }
}
