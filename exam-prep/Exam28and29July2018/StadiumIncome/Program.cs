using System;

namespace StadiumIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            int sectorCount = int.Parse(Console.ReadLine());
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double total = stadiumCapacity * ticketPrice;
            double charity = (total - ((total / sectorCount) * 0.75)) / 8;

            Console.WriteLine($"Total income - {total:f2} BGN");
            Console.WriteLine($"Money for charity - {charity:f2} BGN");
        }
    }
}
