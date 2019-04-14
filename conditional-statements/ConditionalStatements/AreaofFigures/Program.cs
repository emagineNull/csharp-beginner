using System;

namespace AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            double area;
            if (figureType == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
                Console.WriteLine("{0:f3}", area);
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
                Console.WriteLine("{0:f3}", area);
            }
            else if (figureType == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = a * h / 2;
                Console.WriteLine("{0:f3}", area);
            }
            else
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine("{0:f3}", area);
            }
        }
    }
}
