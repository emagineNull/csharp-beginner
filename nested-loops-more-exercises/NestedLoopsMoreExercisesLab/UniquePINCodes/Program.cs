using System;

namespace UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperRangeNum1 = int.Parse(Console.ReadLine());
            int upperRangeNum2 = int.Parse(Console.ReadLine());
            int upperRangeNum3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= upperRangeNum1; i++)
            {
                for (int j = 2; j <= upperRangeNum2; j++)
                {
                    for (int k = 1; k <= upperRangeNum3; k++)
                    {
                        if (k % 2 == 0 && i % 2 == 0 && j != 4 && j != 6 && j <= 7)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
