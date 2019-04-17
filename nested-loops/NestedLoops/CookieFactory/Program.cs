using System;

namespace CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());

            for (int currentBatch = 1; currentBatch <= batches; currentBatch++)
            {
                string product = Console.ReadLine();
                bool hasFlour = false;
                bool hasEggs = false;
                bool hasSugar = false;
                while (true)
                {
                    switch (product)
                    {
                        case "flour":
                            hasFlour = true;
                            break;
                        case "eggs":
                            hasEggs = true;
                            break;
                        case "sugar":
                            hasSugar = true;
                            break;
                        default:
                            break;
                    }

                    if (product == "Bake!" && hasSugar && hasFlour && hasEggs)
                    {
                        Console.WriteLine($"Baking batch number {currentBatch}...");
                        break;
                    }
                    else if (product == "Bake!")
                    {
                        Console.WriteLine($"The batter should contain flour, eggs and sugar!");
                    }

                    product = Console.ReadLine();
                }
               
            }
        }
    }
}
