using System;

namespace InchesToCentimetres
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double cm = inches * 2.54;

            Console.WriteLine("{0:F2}", cm); // Console.WriteLine($"{cm:f2}");

        }
    }
}
