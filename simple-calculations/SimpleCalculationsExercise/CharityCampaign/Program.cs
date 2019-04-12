using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int baker = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double sumRaised = days * (baker * ((cakes * 45) + (waffles * 5.8) + (pancakes * 3.20)));
            double sumRaisedWithExpenses = sumRaised * 0.875;

            Console.WriteLine("{0:f2}", sumRaisedWithExpenses);
        }
    }
}
