using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double score = double.Parse(Console.ReadLine());
            double minWage = double.Parse(Console.ReadLine());

            double scholarship1 = Math.Floor(minWage * 0.35);
            double scholarship2 = Math.Floor(score * 25);

            if (income < minWage && score > 5.5) 
            {
                if (scholarship1 > scholarship2)
                {
                    Console.WriteLine($"You get a Social scholarship {scholarship1} BGN");
                }
                else if (scholarship2 > scholarship1)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scholarship2} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scholarship2} BGN");
                }
            }
            else if (score >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarship2} BGN");
            }
            else if (income < minWage && score > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {scholarship1} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
