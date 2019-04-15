using System;

namespace NumberInRange1To100
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool isValid = number >= 1 && number <= 100;
            while (!isValid)
            {
                Console.WriteLine("Invalid number!");
                number = int.Parse(Console.ReadLine());
                isValid = number >= 1 && number <= 100;
            }

            Console.WriteLine($"The number is: {number}");
        }
    }
}
