using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double cinema = rows * columns;
            double price = 0;

            switch (movie)
            {
                case "Premiere":
                    price = 12.00;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5.00;
                    break;
                default:
                    break;
            }

            double priceFull = cinema * price;
            Console.WriteLine($"{priceFull:f2} leva");
        }
    }
}
