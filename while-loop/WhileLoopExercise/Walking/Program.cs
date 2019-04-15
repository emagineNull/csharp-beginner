using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Steps = 10000;

            int steps = 0;
            int sumSteps = 0;
            string action;
            while (sumSteps < Steps)
            {
                action = Console.ReadLine();
                if (action != "Going home")
                {
                    steps = int.Parse(action);
                    sumSteps += steps;
                }
                else
                {
                    steps = int.Parse(Console.ReadLine());
                    sumSteps += steps;
                    break;
                }
            }

            if (sumSteps >= Steps)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{Steps - sumSteps} more steps to reach goal.");
            }
        }
    }
}
