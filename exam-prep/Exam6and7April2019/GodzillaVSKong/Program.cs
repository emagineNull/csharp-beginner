using System;

namespace GodzillaVSKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothing = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double clothingTotal = statists * clothing;

            if (statists >= 150)
            {
                clothingTotal = statists * (clothing * 0.9);
            }

            if (budget >= decor + clothingTotal)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budget - (decor + clothingTotal):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {decor + clothingTotal - budget:f2} leva more.");
            }
        }
    }
}
