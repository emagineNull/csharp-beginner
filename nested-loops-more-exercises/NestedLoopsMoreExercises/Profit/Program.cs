using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLevaCount = int.Parse(Console.ReadLine());
            int twoLevaCount = int.Parse(Console.ReadLine());
            int fiveLevaCount = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= oneLevaCount; i++)
            {
                for (int k = 0; k <= twoLevaCount; k++)
                {
                    for (int l = 0; l <= fiveLevaCount; l++)
                    {
                        if (i * 1 + k * 2 + l * 5 == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {k} * 2 lv. + {l} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
