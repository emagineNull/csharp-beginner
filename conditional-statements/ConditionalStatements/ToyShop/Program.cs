using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int totalToys = puzzle + doll + bears + minions + trucks;
            double totalToysCost = (puzzle * 2.6) + (doll * 3) + (bears * 4.1) + (minions * 8.2) + (trucks * 2);

            double money;

            if (totalToys >= 50)
            {
                money = (totalToysCost * 0.75) * 0.9;
            }
            else
            {
                money = totalToysCost * 0.9;
            }

            
            if (vacationPrice <= money)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", money - vacationPrice);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed.", vacationPrice - money);
            }
        }
    }
}
