using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((3 + 5) * (4 - 2));
            
            // without paranthesis
            Console.WriteLine(3 + (5 * 4) - 2);

            // integer infinity quotient
            Console.WriteLine(1 / 3);
        }
    }
}
