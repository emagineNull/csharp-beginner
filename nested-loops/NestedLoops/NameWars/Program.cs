using System;

namespace NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int maxValue = 0;
            string winner = string.Empty;
            while (name != "STOP")
            {
                int value = 0;
                for (int letterPosition = 0; letterPosition < name.Length; letterPosition++)
                {
                    char letter = name[letterPosition];
                    value += letter;
                }
                
                if (maxValue < value)
                {
                    maxValue = value;
                    winner = name;
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"Winner is {winner} - {maxValue}!");
        }
    }
}
