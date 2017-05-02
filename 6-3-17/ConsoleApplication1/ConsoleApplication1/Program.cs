using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("What is your name:");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("What is your phone number");
            int PhoneNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PhoneNo);

            Console.WriteLine("how much money you have?");
            double money = Convert.ToDouble(Console.ReadLine());
            Console.Write(money);

            Console.ReadKey();
        }
    }
}
