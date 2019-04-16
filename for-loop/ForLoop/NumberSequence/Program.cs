using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int largest = int.MinValue;
            int smallest = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > largest)
                {
                    largest = number;
                }
                if (number < smallest)
                {
                    smallest = number;
                }
            }

            Console.WriteLine($"Max number: {largest}");
            Console.WriteLine($"Min number: {smallest}");
        }
    }
}
