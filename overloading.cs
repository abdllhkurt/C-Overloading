using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2;

            var result = Add(num1, out num2);
            Console.WriteLine(result);

            num2 = 20;
            int num3 = 140;

            Console.WriteLine("First Multiply function");
            result = Multiply(num1, num2);
            Console.WriteLine(result);

            Console.WriteLine("Second Multiply function");
            result = Multiply(num1, num2, num3);
            Console.WriteLine(result);

            result = Adds(num1, num2, num3);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        // Sum of two numbers
        static int Add(int num1, out int num2) 
        {
            num2 = 20;
            return num1 + num2;
        }

        static int Multiply(int num1, int num2) 
        {
            return num1 * num2;
        }

        static int Multiply(int num1, int num2, int num3) 
        {
            return (num1 * num2 * num3);
        }

        // multi-parameter aggregate function created using arrays
        static int Adds(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}