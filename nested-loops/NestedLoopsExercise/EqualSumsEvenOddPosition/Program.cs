using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());


            for (int i = n1; i <= n2; i++)
            {
                string iString = i.ToString();
                int sumEven = 0;
                int sumOdd = 0;
                for (int j = 0; j <= 5; j++)
                {
                    char currentDigit = iString[j];
                    int currentDigitToNumber = (int)Char.GetNumericValue(currentDigit);

                    int counter = j + 1;
                    if (counter % 2 == 0)
                    {
                        sumEven += currentDigitToNumber;
                    }
                    else if (counter % 2 != 0)
                    {
                        sumOdd += currentDigitToNumber;
                    }
                }
                if (sumEven == sumOdd)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
