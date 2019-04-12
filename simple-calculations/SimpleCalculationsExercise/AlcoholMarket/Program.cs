using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerLitres = double.Parse(Console.ReadLine());
            double wineLitres = double.Parse(Console.ReadLine());
            double rakiaLitres = double.Parse(Console.ReadLine());
            double whiskeyLitres = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice * 0.6;
            double beerPrice = rakiaPrice * 0.2;

            double totalSum = (whiskeyPrice * whiskeyLitres) + (beerLitres * beerPrice) + (wineLitres * winePrice)
                + (rakiaPrice * rakiaLitres);

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
