using System;

namespace CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerNum = int.Parse(Console.ReadLine());
            int upperNum = int.Parse(Console.ReadLine());

            for (int i = lowerNum; i <= upperNum; i++)
            {
                for (int j = lowerNum; j <= upperNum; j++)
                {
                    for (int k = lowerNum; k <= upperNum; k++)
                    {
                        for (int l = lowerNum; l <= upperNum; l++)
                        {
                            if (i % 2 == 0 && l % 2 != 0)
                            {
                                if (i > l && (j + k) % 2 == 0)
                                {
                                    Console.Write($"{i}{j}{k}{l} ");
                                }
                            }
                            else if (i % 2 != 0 && l % 2 == 0)
                            {
                                if (i > l && (j + k) % 2 == 0)
                                {
                                    Console.Write($"{i}{j}{k}{l} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
