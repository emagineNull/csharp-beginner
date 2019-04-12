using System;

namespace RoundingNubmers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a real number for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter a real number for b: ");
            double b = double.Parse(Console.ReadLine());

            double result = a / b;
            double roundedResult = Math.Round(result, 1);
            double floorResult = Math.Floor(result);
            double ceilingResult = Math.Ceiling(result);

            Console.WriteLine($"Math.Round = {roundedResult}");
            Console.WriteLine($"Math.Floor = {floorResult}");
            Console.WriteLine($"Math.Ceiling = {ceilingResult}");
            Console.WriteLine($"Formatted result = {result:f1}");
        }
    }
}
