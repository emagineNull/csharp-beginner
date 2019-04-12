using System;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // judge
            int a = int.Parse(Console.ReadLine());
            int area = a * a;

            Console.WriteLine(area);

            // type casting
            string bAsText = Console.ReadLine();

            int b = int.Parse(bAsText);

            int squareArea = a * a;

            Console.WriteLine(area);

            // more type casting
            int count = int.Parse("5"); // int count = "5"; Error!!

            string input = Console.ReadLine(); // i enter "5"
            int num = int.Parse(input); // 5 
        }
    }
}
