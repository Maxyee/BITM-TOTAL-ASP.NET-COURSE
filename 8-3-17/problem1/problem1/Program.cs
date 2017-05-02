using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Give an Upper Limit:");
            int Upper = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Give an Lower Limit:");
            int lower = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("So All integer Between Them is: ");
            for (int i = Upper; i <= lower; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
