using System;

namespace Scratchpad
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            double realNumber = 1;
            int integer = (int)5.66;

            Console.WriteLine();
            Console.WriteLine(integer);

            Console.WriteLine();
            Console.WriteLine((char)75);

            Console.WriteLine();
            Console.WriteLine((int)'a');

            Console.WriteLine();
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
