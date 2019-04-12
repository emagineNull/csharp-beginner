using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double volumeReal = (volume * (1 - procent / 100)) * 0.001; 

            Console.WriteLine("{0:f3}", volumeReal);
        }
    }
}
