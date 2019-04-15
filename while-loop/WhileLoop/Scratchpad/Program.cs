using System;

namespace Scratchpad
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"a = {a++}");
            Console.WriteLine($"a = {++a}");

            Console.WriteLine("----------------------------------------------");

            int b = int.Parse(Console.ReadLine());
            int expression = b++ + ++b;
            Console.WriteLine(expression);

            Console.WriteLine("----------------------------------------------");

            int c = int.Parse(Console.ReadLine());

            while (c <= 10)
            {
                Console.WriteLine($"c = {c}");
                c++;
            }

            Console.WriteLine("----------------------------------------------");
        }
    }
}
