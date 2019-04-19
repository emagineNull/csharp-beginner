using System;

namespace BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beerCount = int.Parse(Console.ReadLine());
            int chipsCount = int.Parse(Console.ReadLine());

            double beerBought = beerCount * 1.2;
            double chipsBought = Math.Ceiling(beerBought * 0.45 * chipsCount);

            double total = beerBought + chipsBought;

            if (budget >= total)
            {
                Console.WriteLine($"{name} bought a snack and has {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {total - budget:f2} more leva!");
            }
        }
    }
}
