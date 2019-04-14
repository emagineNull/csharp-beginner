using System;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            
            double stepsPerDayPercentage = (steps * 1.0 / days) / steps;
            stepsPerDayPercentage *= 100;
            stepsPerDayPercentage = Math.Ceiling(stepsPerDayPercentage);
            double stepsPerDancerPerDayPercentage = stepsPerDayPercentage / dancers;

            if (stepsPerDayPercentage <= 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", stepsPerDancerPerDayPercentage);
            }
            else
            {
                Console.WriteLine("No, they will not succeed in that goal! Required {0:f2}% steps to be learned per day.", stepsPerDancerPerDayPercentage);
            }
        }
    }
}
