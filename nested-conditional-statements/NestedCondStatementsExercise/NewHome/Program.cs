using System;

namespace NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;
            double moneyToPay = 0;
            double discount = 0;
            double overcharge = 0;

            switch (flowers)
            {
                case "Roses":
                    if (flowersCount > 80)
                    {
                        price = 5;
                        discount = 0.10;
                    }
                    else
                    {
                        price = 5;
                    }
                    break;
                case "Dahlias":
                    if (flowersCount > 90)
                    {
                        price = 3.80;
                        discount = 0.15;
                    }
                    else
                    {
                        price = 3.80;
                    }
                    break;
                case "Tulips":
                    if (flowersCount > 80)
                    {
                        price = 2.80;
                        discount = 0.15;
                    }
                    else
                    {
                        price = 2.80;
                    }
                    break;
                case "Narcissus":
                    if (flowersCount < 120)
                    {
                        price = 3;
                        overcharge = 1.15;
                    }
                    else
                    {
                        price = 3;
                    }
                    break;
                case "Gladiolus":
                    if (flowersCount < 80)
                    {
                        price = 2.50;
                        overcharge = 1.20;
                    }
                    else
                    {
                        price = 2.50;
                    }
                    break;
                default:
                    break;
            }

            
            if (discount != 0)
            {
                moneyToPay = flowersCount * price - (discount * flowersCount * price);
            }
            else if (overcharge != 0)
            {
                moneyToPay = flowersCount * price * overcharge;
            }
            else
            {
                moneyToPay = flowersCount * price;
            }

            
            if (budget >= moneyToPay && discount != 0 && overcharge == 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and " +
                    $"{budget - moneyToPay:f2} leva left.");
            }
            else if (budget >= moneyToPay && overcharge != 0 && discount == 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and " +
                    $"{budget - moneyToPay:f2} leva left.");
            }
            else if (budget < moneyToPay && discount != 0 && overcharge == 0)
            {
                Console.WriteLine($"Not enough money, you need {moneyToPay - budget:f2} leva more.");
            }
            else if (budget < moneyToPay && overcharge != 0 && discount == 0)
            {
                Console.WriteLine($"Not enough money, you need {moneyToPay - budget:f2} leva more.");
            }
            else if (budget >= moneyToPay && (discount == 0 && overcharge == 0))
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and " +
                    $"{budget - moneyToPay:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {moneyToPay - budget:f2} leva more.");
            }
        }
    }
}
