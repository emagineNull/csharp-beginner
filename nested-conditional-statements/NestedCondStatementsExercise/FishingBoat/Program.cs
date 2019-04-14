using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            int boatPrice = 0;
            double discount = 0; 

            switch (season)
            {
                case "Spring":
                    boatPrice = 3000;
                    break;
                case "Summer":
                    boatPrice = 4200;
                    break;
                case "Autumn":
                    boatPrice = 4200;
                    break;
                case "Winter":
                    boatPrice = 2600;
                    break;
                default:
                    break;
            }

            if (fishermen <= 6)
            {
                discount = 0.10;
            }
            else if (fishermen >=7 && fishermen <= 11)
            {
                discount = 0.15;
            }
            else
            {
                discount = 0.25;
            }

            double priceTotal = 0;
            double bonusDiscount = 0;
            if (fishermen % 2 == 0 && season != "Autumn")
            {
                bonusDiscount = 0.95;
                priceTotal = (boatPrice - (boatPrice * discount)) * bonusDiscount;
            }
            else
            {
                priceTotal = boatPrice - (boatPrice * discount);
            }

            if (priceTotal <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - priceTotal:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {priceTotal - budget:f2} leva.");
            }
        }
    }
}
