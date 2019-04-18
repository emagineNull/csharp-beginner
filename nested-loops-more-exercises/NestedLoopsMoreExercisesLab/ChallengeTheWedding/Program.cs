using System;

namespace ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            int tableCounter = 0;
            int possibleCombinations = 0;

            for (int i = 1; i <= men; i++)
            {
                for (int j = 1; j <= women; j++)
                {
                    if (tableCounter >= tables || possibleCombinations >= men * women)
                    {
                        break;
                    }
                    Console.Write($"({i} <-> {j}) ");
                    tableCounter += 1;
                    possibleCombinations += 1;
                }
            }
        }
    }
}
