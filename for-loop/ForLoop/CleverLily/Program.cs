using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double leva = 0;
            int toy = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    leva += 10 * (i / 2) - 1;
                }
                else
                {
                    toy++;
                }
            }
           
            if (price <= leva + (toy * toyPrice))
            {
                Console.WriteLine($"Yes! {leva + (toy * toyPrice) - price:f2}");
            }
            else
            {
                Console.WriteLine($"No! {price - (leva + (toy * toyPrice)):f2}");
            }
        }
    }
}
