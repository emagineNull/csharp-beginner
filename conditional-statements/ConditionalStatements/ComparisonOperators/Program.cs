using System;

namespace ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Example";
            string b = a;

            Console.WriteLine(a == b);

            string a2 = Console.ReadLine();
            string b2 = Console.ReadLine();

            Console.WriteLine(a2 == b2);
        }
    }
}
