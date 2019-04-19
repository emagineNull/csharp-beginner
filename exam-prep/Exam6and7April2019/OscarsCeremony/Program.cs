using System;

namespace OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statues = rent * 0.7;
            double catering = statues * 0.85;
            double sound = catering * 0.5;

            Console.WriteLine($"{rent + statues + catering + sound:f2}");
        }
    }
}
