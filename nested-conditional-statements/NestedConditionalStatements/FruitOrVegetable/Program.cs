using System;

namespace FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isFruit = input == "banana" || input == "apple" || input == "kiwi" || input == "cherry" ||
                input == "lemon" || input == "grapes";

            bool isVegetable = input == "tomato" || input == "carrot" || input == "pepper"
                || input == "cucumber";

            if (isFruit)
            {
                Console.WriteLine("fruit");
            }
            else if (isVegetable)
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
