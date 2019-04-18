using System;

namespace HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sumTotal = 0;

            for (int i = 1; i <= days; i++)
            {
                double sumDay = 0;
                for (int k = 1; k <= hours; k++)
                {
                    if (i % 2 == 0 && k % 2 == 1)
                    {
                        sumDay += 2.5;
                    }
                    else if (i % 2 == 1 && k % 2 == 0)
                    {
                        sumDay += 1.25;
                    }
                    else
                    {
                        sumDay += 1.0;
                    }                    
                }
                sumTotal += sumDay;
                Console.WriteLine($"Day: {i} - {sumDay:f2} leva");
            }

            Console.WriteLine($"Total: {sumTotal:f2} leva");
        }
    }
}
