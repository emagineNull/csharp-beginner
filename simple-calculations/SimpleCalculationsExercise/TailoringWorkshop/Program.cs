using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double cover = (length + 2 * 0.3) * (width + 2 * 0.3);
            double smallCover = (length / 2) * (length / 2);

            double priceCoversUSD = (7 * cover + 9 * smallCover) * tables;
            double priceCoversBGN = priceCoversUSD * 1.85;

            Console.WriteLine($"{priceCoversUSD:f2} USD");
            Console.WriteLine($"{priceCoversBGN:f2} BGN");
        }
    }
}
