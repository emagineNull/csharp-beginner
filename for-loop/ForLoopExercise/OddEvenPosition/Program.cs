namespace Odd_Even_Positions
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double evenSum = 0.0;
            double oddSum = 0.0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddSum += number;

                    if (number < oddMin)
                    {
                        oddMin = number;
                    }

                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                }
                else if (i % 2 == 0)
                {
                    evenSum += number;

                    if (number < evenMin)
                    {
                        evenMin = number;
                    }

                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                }
            }


            if (n == 0)
            {
                Console.WriteLine($"OddSum={oddSum:f2},\nOddMin=No,\nOddMax=No,\nEvenSum={evenSum:f2},\nEvenMin=No,\nEvenMax=No");
            }
            else if (n == 1)
            {
                Console.WriteLine($"OddSum={oddSum:f2},\nOddMin={oddMin:f2},\nOddMax={oddMax:f2}," +
                    $"\nEvenSum={evenSum:f2},\nEvenMin=No,\nEvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},\nOddMin={oddMin:f2},\nOddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},\nEvenMin={evenMin:f2},\nEvenMax={evenMax:f2}");
            }
        }
    }
}