using System;

namespace BasicOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // integers
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"a = {a}\nb = {b}");

            int sum = a + b;
            Console.WriteLine($"a + b = {sum}");

            int subtractionResult = a - b;
            Console.WriteLine($"a - b = {subtractionResult}");

            int product = a * b;
            Console.WriteLine($"a * b = {product}");

            int quotient = a / b;
            Console.WriteLine($"a / b = {quotient}");

            int remainder = a % b;
            Console.WriteLine($"a % b = {remainder}");

            // double
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"x = {x}\ny = {y}");

            double sum2 = x + y;
            Console.WriteLine($"x + y = {sum2}");

            double subtractionResult2 = x - y;
            Console.WriteLine($"x - y = {subtractionResult2}");

            double product2 = x * y;
            Console.WriteLine($"x * y = {product2}");

            double quotient2 = x / y;
            Console.WriteLine($"x / y = {quotient2}");

            double remainder2 = x % y;
            Console.WriteLine($"x % y = {remainder2}");
        }
    }
}
