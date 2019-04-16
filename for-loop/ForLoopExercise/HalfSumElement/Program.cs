using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int largest = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= largest)
                {
                    largest = number;
                    sum += number;
                }
                else
                {
                    sum += number;
                }
            }

            sum -= largest;
            if (largest == sum)
            {
                Console.WriteLine($"Yes\nSum = {largest}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(sum - largest)}");
            }
        }
    }
}
