using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            int goals = 0;

            bool hattrick = false;
            int goalScored = 0;
            string bestPlayer = string.Empty;

            while (true)
            {
                name = Console.ReadLine();

                if (name == "END")
                {
                    break;
                }

                goals = int.Parse(Console.ReadLine());

                if (goalScored < goals)
                {
                    goalScored = goals;
                    bestPlayer = name;
                    if (goalScored >= 3)
                    {
                        hattrick = true;
                    }
                }

                if (goals >= 10)
                {
                    goalScored = goals;
                    bestPlayer = name;
                    hattrick = true;
                    break;
                }

            }

            Console.WriteLine($"{bestPlayer} is the best player!");
            if (hattrick)
            {
                Console.WriteLine($"He has scored {goalScored} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goalScored} goals.");
            }
        }
    }
}
