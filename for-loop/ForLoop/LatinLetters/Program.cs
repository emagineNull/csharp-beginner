using System;

namespace LatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // My way
            for (int i = 97; i <= 122; i++)
            {
                Console.WriteLine((char)i);
            }

            // Lecture way
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
