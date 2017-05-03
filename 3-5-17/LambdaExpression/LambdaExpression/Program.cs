using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        private delegate int CalculatorMethodHandler(int firstNumber, int secoundNumber);
        static void Main(string[] args)
        {
            CalculatorMethodHandler addHandler1 = Add;
            CalculatorMethodHandler addHandler2 = Subtract;
            var result = addHandler1(3, 4);
            result = addHandler2(4, 3);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int Add(int firstNumber, int secoundNumber)
        {
            return firstNumber + secoundNumber;
        }

        public static int Subtract(int firstNumber, int secoundNumber)
        {
            return firstNumber - secoundNumber;
        }
    }
}
