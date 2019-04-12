using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());

            Console.WriteLine($"The final price is: {(squareMeters * 7.61) * 0.82:f2} lv.");
            Console.WriteLine($"The discount is: {(squareMeters * 7.61) * 0.18:f2} lv.");
        }
    }
}
