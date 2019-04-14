using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsAtHome = int.Parse(Console.ReadLine());

            double daysPlayedInSofia = 0;
            double daysPlayedAtHome = 0;
            double total = 0;

            if (year == "normal")
            {
                daysPlayedInSofia = (48.0 - weekendsAtHome) * (3.0 / 4) + (holidays * (2.0 / 3));
                daysPlayedAtHome = weekendsAtHome * 1.0;
                total = daysPlayedInSofia + daysPlayedAtHome;
            }
            else
            {
                daysPlayedInSofia = (48.0 - weekendsAtHome) * (3.0 / 4) + (holidays * (2.0 / 3));
                daysPlayedAtHome = weekendsAtHome * 1.0;
                total = (daysPlayedInSofia + daysPlayedAtHome) * 1.15;
            }

            Console.WriteLine(Math.Floor(total));
        }
    }
}
