using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int durationOfStay = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartment = 0;

            switch (month)
            {
                case "May":
                    if (durationOfStay <= 7)
                    {
                        priceStudio = 50;
                    }
                    else if (durationOfStay > 7 && durationOfStay <= 14)
                    {
                        priceStudio = 50 * 0.95;
                    }
                    else
                    {
                        priceStudio = 50 * 0.70;
                    }
                    priceApartment = 65;
                    break;
                case "June":
                    if (durationOfStay <= 14)
                    {
                        priceStudio = 75.20;
                    }
                    else
                    {
                        priceStudio = 75.20 * 0.80;
                    }
                    priceApartment = 68.70;
                    break;
                case "July":                    
                    priceStudio = 76;
                    priceApartment = 77;
                    break;
                case "August":
                    priceStudio = 76;
                    priceApartment = 77;
                    break;
                case "September":
                    if (durationOfStay <= 14)
                    {
                        priceStudio = 75.20;
                    }
                    else
                    {
                        priceStudio = 75.20 * 0.80;
                    }
                    priceApartment = 68.70;
                    break;
                case "October":
                    if (durationOfStay <= 7)
                    {
                        priceStudio = 50;
                    }
                    else if (durationOfStay > 7 && durationOfStay <= 14)
                    {
                        priceStudio = 50 * 0.95;
                    }
                    else
                    {
                        priceStudio = 50 * 0.70;
                    }
                    priceApartment = 65;
                    break;
                default:
                    break;
            }
            
            double priceTotalApartment = priceApartment * (durationOfStay * 1.0);
            double priceTotalStudio = priceStudio * (durationOfStay * 1.0);

            if (durationOfStay > 14)
            {
                priceApartment *= 0.90;
                priceTotalApartment = priceApartment * (durationOfStay * 1.0);
                Console.WriteLine($"Apartment: {priceTotalApartment:f2} lv." +
                    $"\nStudio: {priceTotalStudio:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Apartment: {priceTotalApartment:f2} lv." +
                    $"\nStudio: {priceTotalStudio:f2} lv.");
            }
        }
    }
}
