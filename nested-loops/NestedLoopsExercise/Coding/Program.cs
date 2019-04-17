using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            
            for (int rows = number.Length - 1; rows >= 0; rows--)
            {
                char currentDigit = number[rows];
                int currentDigitToNumber = int.Parse(currentDigit.ToString());

                if (currentDigitToNumber == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }

                for (int col = 0; col < currentDigitToNumber; col++)
                {
                    Console.Write((char)(currentDigitToNumber + 33));
                }

                Console.WriteLine();
            }
        }
    }
}
