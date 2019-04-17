using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                string iString = i.ToString();
                for (int j = 1; j < 5; j++)
                {
                    int currentDigit = int.Parse(iString[j - 1].ToString());
                    if (currentDigit == 0)
                    {
                        break;
                    }
                    if (n % currentDigit == 0)
                    {
                        if (j == 4)
                        {
                            Console.Write(iString + " ");
                            break;
                        }
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
            }
        }
    }
}
