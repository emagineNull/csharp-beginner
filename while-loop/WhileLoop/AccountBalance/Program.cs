using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int deposit = int.Parse(Console.ReadLine());

            int counter = 0;
            double total = 0;
            double sum;
            while (counter < deposit)
            {
                sum = double.Parse(Console.ReadLine());
                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {sum:f2}");
                total += sum;
                counter++;
            }

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
