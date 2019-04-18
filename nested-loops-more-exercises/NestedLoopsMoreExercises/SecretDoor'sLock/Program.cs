using System;

namespace SecretDoor_sLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundreds = int.Parse(Console.ReadLine());
            int tens = int.Parse(Console.ReadLine());
            int ones = int.Parse(Console.ReadLine());

            for (int i = 1; i <= hundreds; i++)
            {
                for (int j = 1; j <= tens; j++)
                {
                    for (int k = 1; k <= ones; k++)
                    {
                        if (i % 2 == 0 && k % 2 == 0 && j > 1 && j < 8 && j != 4 && j != 6)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
