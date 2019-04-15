using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            const int PieceOfCake = 1 * 1;

            int areaOfCake = width * length;

            while (areaOfCake >= 0)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    Console.WriteLine($"{areaOfCake} pieces are left.");
                    break;
                }
                else
                {
                    areaOfCake -= int.Parse(command) * PieceOfCake;
                }
            }

            if (areaOfCake < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(areaOfCake)} pieces more.");
            }
        }
    }
}
