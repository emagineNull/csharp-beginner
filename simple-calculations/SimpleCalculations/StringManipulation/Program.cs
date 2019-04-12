using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
        }
    }
}
