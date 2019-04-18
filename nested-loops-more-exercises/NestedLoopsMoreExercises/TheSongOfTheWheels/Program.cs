using System;

namespace TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());

            int numCounter = 0;
            string num = string.Empty;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if (m == i * j + k * l)
                            {
                                if (i < j && k > l)
                                {
                                    Console.Write($"{i}{j}{k}{l} ");
                                    numCounter++;
                                    if (numCounter == 4)
                                    {
                                        num = i.ToString();
                                        num += j.ToString();
                                        num += k.ToString();
                                        num += l.ToString();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (numCounter > 0)
            {
                Console.WriteLine();
            }

            if (numCounter >= 4)
            {
                Console.WriteLine($"Password: {num}");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
