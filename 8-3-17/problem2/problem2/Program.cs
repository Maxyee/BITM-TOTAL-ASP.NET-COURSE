using System;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 100;
            
            Console.WriteLine("For Loop Even number Count: ");
            for (int k = i; k <= j; k++)
            {
                if (k%2 == 0)
                {
                    Console.WriteLine(k);
                }
            }

            Console.WriteLine("While Loop Even number Count: ");
            while (i<=j)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                    
                }
                i++;
            }
            Console.WriteLine("Do While Loop Even number Count: ");

            int mohon = 1;
            int khan = 100;
            do
            {
                if (mohon%2 == 0)
                {
                    Console.WriteLine(mohon);
                }
                mohon++;     
            } while (mohon<=khan);
            
            Console.ReadKey();
        }
    }
}
