using System;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int quota = int.Parse(Console.ReadLine());
            string fishName = Console.ReadLine();

            int fish = 0;
            double total = 0;
            double totalWon = 0;
            double totalLost = 0;
            while (fishName != "Stop")
            {
                fish++;
                int characterAsciiNum = 0;
                double fishPrice = 0;
                double fishWeight = double.Parse(Console.ReadLine());

                for (int i = 0; i < fishName.Length; i++)
                {
                    characterAsciiNum = fishName[i];
                    fishPrice += characterAsciiNum;
                }

                fishPrice /= fishWeight;

                if (fish % 3 == 0)
                {
                    totalWon += fishPrice;
                }
                else
                {
                    totalLost += fishPrice;
                }

                if (fish == quota)
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    break;
                }

                fishName = Console.ReadLine();
            }

            if (totalWon > totalLost)
            {
                total = totalWon - totalLost;
                Console.WriteLine($"Lyubo's profit from {fish} fishes is {total:f2} leva.");
            }
            else
            {
                total = totalLost - totalWon;
                Console.WriteLine($"Lyubo lost {total:f2} leva today.");
            }
        }
    }
}
