using System;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1000; i <= 9999; i++)
            {
                string iString = i.ToString();
                int firstSum = 0;
                int secondSum = 0;
                for (int j = 0; j <= 4; j++)
                {
                    if (j == 4)
                    {
                        if (firstSum == secondSum && n % firstSum == 0)
                        {
                            Console.Write($"{i} ");
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    int currentDigit = int.Parse(iString[j].ToString());
                    if (currentDigit == 0)
                    {
                        break;
                    }
                    if (j < 2)
                    {
                        firstSum += currentDigit;
                    }
                    else
                    {
                        secondSum += currentDigit;
                    }
                }
            }
        }
    }
}
