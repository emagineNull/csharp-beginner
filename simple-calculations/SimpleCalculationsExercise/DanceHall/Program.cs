using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double hallArea = L * W * 10000;
            double wardrobeArea = A * A * 10000;

            double bench = hallArea / 10;

            double space = (hallArea - wardrobeArea - bench) / 7040;

            Console.WriteLine(Math.Floor(space));
        }
    }
}
