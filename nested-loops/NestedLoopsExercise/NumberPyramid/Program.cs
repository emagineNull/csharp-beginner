using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = 1;
            for (int rowCounter = 0; rowCounter < n; rowCounter++)
            {
                for (int numberPosition = 1; numberPosition <= rowCounter + 1; numberPosition++)
                {
                    Console.Write(number++ + " ");
                    if (number == n + 1)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (number == n + 1)
                {
                    break;
                }
            }
        }
    }
}
