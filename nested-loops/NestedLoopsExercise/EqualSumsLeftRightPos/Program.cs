using System;

namespace EqualSumsLeftRightPos
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
                int leftSum = 0;
                int rightSum = 0;
                int middleDigit = 0;
                for (int j = 0; j < 5; j++)
                {
                    int currentDigit = int.Parse(iString[j].ToString());

                    if (j < 2)
                    {
                        leftSum += currentDigit;
                    }
                    if (j > 2 && j < 5)
                    {
                        rightSum += currentDigit;
                    }

                    if (j == 2)
                    {
                        middleDigit = currentDigit;
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.Write(i + " ");
                }

                if (leftSum < rightSum)
                {
                    leftSum += middleDigit;
                    if (leftSum == rightSum)
                    {
                        Console.Write(i + " ");
                    }
                }

                if (rightSum < leftSum)
                {
                    rightSum += middleDigit;
                    if (rightSum == leftSum)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
