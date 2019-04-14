using System;

namespace PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool xIsTrue = x >= x1 && x <= x2;
            bool yIsTrue = y >= y1 && y <= y2;

            if (xIsTrue && yIsTrue)
            {
                if (xIsTrue && (y == y1 || y == y2))
                {
                    Console.WriteLine("Border");
                }
                else if (yIsTrue && (x == x1 || x == x2))
                {
                    Console.WriteLine("Border");
                }
                else
                {
                    Console.WriteLine("Inside / Outside");
                }
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
