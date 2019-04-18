using System;

namespace LetterCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char lowerLetter = char.Parse(Console.ReadLine());
            char upperLetter = char.Parse(Console.ReadLine());
            char skipLetter = char.Parse(Console.ReadLine());

            int combinationCount = 0;

            for (int i = lowerLetter; i <= upperLetter; i++)
            {
                for (int j = lowerLetter; j <= upperLetter; j++)
                {
                    for (int k = lowerLetter; k <= upperLetter; k++)
                    {
                        if (i != skipLetter && j != skipLetter && k != skipLetter)
                        {
                            Console.Write($"{(char)i}{(char)j}{(char)k} ");
                            combinationCount++;
                        }
                    }
                }
            }

            Console.Write(combinationCount);
        }
    }
}
