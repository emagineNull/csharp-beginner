using System;

namespace FanShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int items = int.Parse(Console.ReadLine());

            string itemName = string.Empty;
            int total = 0;

            for (int i = 1; i <= items; i++)
            {
                itemName = Console.ReadLine();
                if (itemName == "hoodie")
                {
                    total += 30;
                }
                else if (itemName == "keychain")
                {
                    total += 4;
                }
                else if (itemName == "T-shirt")
                {
                    total += 20;
                }
                else if (itemName == "flag")
                {
                    total += 15;
                }
                else if (itemName == "sticker")
                {
                    total++;
                }
            }

            if (budget >= total)
            {
                Console.WriteLine($"You bought {items} items and left with {budget - total} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {total - budget} more lv.");
            }
        }
    }
}
