﻿using System;

namespace CircleAndAreaPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;
            double perimeter = 2 * Math.PI * radius;

            Console.WriteLine("{0:f2}", area);
            Console.WriteLine("{0:f2}", perimeter);
        }
    }
}
