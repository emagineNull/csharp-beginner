using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();
            double converted = 0;

            if (inputMetric == "m" && outputMetric == "cm")
            {
                converted = value * 100;
            }
            else if (inputMetric == "m" && outputMetric == "mm")
            {
                converted = value * 1000;
            }
            else if (inputMetric == "cm" && outputMetric == "m")
            {
                converted = value / 100;
            }
            else if (inputMetric == "cm" && outputMetric == "mm")
            {
                converted = value * 10;
            }
            else if (inputMetric == "mm" && outputMetric == "cm")
            {
                converted = value / 10;
            }
            else
            {
                converted = value / 1000;
            }

            Console.WriteLine($"{converted:f3}");
        }
    }
}
