using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string place = " ";
            string location = " ";
            double moneySpent = 0;
            if (season == "summer")
            {
                if (budget <= 100)
                {
                    moneySpent = budget * 0.3;
                    location = "Bulgaria";
                    place = "Camp";
                }
                else if (budget <= 1000)
                {
                    moneySpent = budget * 0.4;
                    location = "Balkans";
                    place = "Camp";
                }
                else
                {
                    moneySpent = budget * 0.9;
                    location = "Europe";
                    place = "Hotel";
                }
            }
            else
            {
                if (budget <= 100)
                {
                    moneySpent = budget * 0.7;
                    location = "Bulgaria";
                    place = "Hotel";
                }
                else if (budget <= 1000)
                {
                    moneySpent = budget * 0.8;
                    location = "Balkans";
                    place = "Hotel";
                }
                else
                {
                    moneySpent = budget * 0.9;
                    location = "Europe";
                    place = "Hotel";
                }
            }

            Console.WriteLine($"Somewhere in {location}\n{place} - {moneySpent:f2}");
        }
    }
}
