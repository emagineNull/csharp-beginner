using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string review = Console.ReadLine();

            double discount = 0;
            double price = 0;
            double priceTotal = 0;
            if (review == "positive")
            {
                switch (room)
                {
                    case "room for one person":
                        discount = 0;
                        price = 18;
                        break;
                    case "apartment":
                        price = 25;
                        if (days - 1 < 10)
                        {
                            discount = 0.3;
                        }
                        else if (days - 1 >= 10 && days - 1 <= 15)
                        {
                            discount = 0.35;
                        }
                        else
                        {
                            discount = 0.5;
                        }
                        break;
                    case "president apartment":
                        price = 35;
                        if (days - 1 < 10)
                        {
                            discount = 0.1;
                        }
                        else if (days - 1 >= 10 && days - 1 <= 15)
                        {
                            discount = 0.15;
                        }
                        else
                        {
                            discount = 0.2;
                        }
                        break;
                    default:
                        break;
                }
                priceTotal = (price - (price * discount)) * (days - 1);
                Console.WriteLine($"{priceTotal * 1.25:f2}");
            }
            else
            {
                switch (room)
                {
                    case "room for one person":
                        discount = 0;
                        price = 18;
                        break;
                    case "apartment":
                        price = 25;
                        if (days - 1 < 10)
                        {
                            discount = 0.3;
                        }
                        else if (days - 1 >= 10 && days - 1 <= 15)
                        {
                            discount = 0.35;
                        }
                        else
                        {
                            discount = 0.5;
                        }
                        break;
                    case "president apartment":
                        price = 35;
                        if (days - 1 < 10)
                        {
                            discount = 0.1;
                        }
                        else if (days - 1 >= 10 && days - 1 <= 15)
                        {
                            discount = 0.15;
                        }
                        else
                        {
                            discount = 0.2;
                        }
                        break;
                    default:
                        break;
                }
                priceTotal = (price - (price * discount)) * (days - 1);
                Console.WriteLine($"{priceTotal * 0.9:f2}");
            }
        }
    }
}
