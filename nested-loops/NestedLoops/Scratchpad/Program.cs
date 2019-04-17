using System;

namespace Scratchpad
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            int a = 3;
            int b = 3;

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("i = " + i);
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine("j = " + j);
                }
            }
        }
    }
}
