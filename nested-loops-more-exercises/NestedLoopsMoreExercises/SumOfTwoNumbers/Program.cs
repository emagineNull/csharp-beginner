using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combinationNumber = 0;
            int combinationCounter = 0;
            int firstNum = 0; 
            int secondNum = 0;

            for (int i = n1; i <= n2; i++)
            {
                for (int k = n1; k <= n2; k++)
                {
                    if (i + k == magicNumber)
                    {
                        combinationCounter++;
                        combinationNumber = combinationCounter;
                        firstNum = i;
                        secondNum = k;
                        break;
                    }
                    else
                    {
                        combinationCounter++;
                    }
                }
                if (combinationNumber != 0)
                {
                    break;
                }
            }

            if (combinationNumber == 0)
            {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");
            }
            else
            {
                Console.WriteLine($"Combination N:{combinationNumber} ({firstNum} + {secondNum} = " +
                    $"{magicNumber})");
            }
        }
    }
}
