using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double resistance = Math.Floor(meters / 15);
            double ivanTime = meters * timePerMeter + (resistance * 12.5);

            if (ivanTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {ivanTime - record:f2} seconds slower.");
            }
        }
    }
}
