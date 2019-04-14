using System;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrother = double.Parse(Console.ReadLine());
            double secondBrother = double.Parse(Console.ReadLine());
            double thirdBrother = double.Parse(Console.ReadLine());
            double father = double.Parse(Console.ReadLine());

            double totalTime = 1 / (1 / firstBrother + 1 / secondBrother + 1 / thirdBrother) * 1.15;

            Console.WriteLine($"Cleaning time: {totalTime:f2}");

            if (father >= totalTime)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(father - totalTime)} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(totalTime - father)} hours.");
            }
        }
    }
}
