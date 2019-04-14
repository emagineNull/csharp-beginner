using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double productPrice = 0;
            if (town == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        productPrice = 0.5;
                        break;
                    case "water":
                        productPrice = 0.8;
                        break;
                    case "beer":
                        productPrice = 1.2;
                        break;
                    case "sweets":
                        productPrice = 1.45;
                        break;
                    case "peanuts":
                    default:
                        productPrice = 1.6;
                        break;
                }
            }
            else if (town == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        productPrice = 0.45;
                        break;
                    case "water":
                        productPrice = 0.7;
                        break;
                    case "beer":
                        productPrice = 1.10;
                        break;
                    case "sweets":
                        productPrice = 1.35;
                        break;
                    case "peanuts":
                    default:
                        productPrice = 1.55;
                        break;
                }
            }
            else
            {
                switch (product)
                {
                    case "coffee":
                        productPrice = 0.4;
                        break;
                    case "water":
                        productPrice = 0.7;
                        break;
                    case "beer":
                        productPrice = 1.15;
                        break;
                    case "sweets":
                        productPrice = 1.3;
                        break;
                    case "peanuts":
                    default:
                        productPrice = 1.5;
                        break;
                }                
            }
            double productPriceTotal = productPrice * quantity;
            Console.WriteLine(productPriceTotal);
        }
    }
}
