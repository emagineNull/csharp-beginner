using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int boxes = int.Parse(Console.ReadLine());
            
            int volumeCondo = width * length * height;
            volumeCondo -= boxes;

            while (volumeCondo > 0)
            {
                string done = Console.ReadLine();
                if (done == "Done")
                {
                    break;
                }
                boxes = int.Parse(done);
                volumeCondo -= boxes;
            }            

            if (volumeCondo >= 0)
            {
                Console.WriteLine($"{volumeCondo} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volumeCondo)} Cubic meters more.");
            }
        }
    }
}
