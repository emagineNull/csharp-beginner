using System;

namespace AreaofFiguresSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            double area = 0;
            switch (figureType)
            {
                case "rectangle":
                    {
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        area = a * b;
                    }
                    break;
                case "circle":
                    {
                        double radius = double.Parse(Console.ReadLine());
                        area = Math.PI * radius * radius;
                    }
                    break;
                case "triangle":
                    {
                        double a = double.Parse(Console.ReadLine());
                        double h = double.Parse(Console.ReadLine());
                        area = a * h / 2;
                    }
                    break;
                case "square":
                default:
                    {
                        double a = double.Parse(Console.ReadLine());
                        area = a * a;
                    }
                    break;
            }

            Console.WriteLine("{0:f3}", area);
        }
    }
}
