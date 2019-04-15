using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyVacation = double.Parse(Console.ReadLine());
            double moneyOnHand = double.Parse(Console.ReadLine());

            int counter = 0;
            int days = 0;

            while (moneyOnHand < moneyVacation && counter < 5)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                if (action == "save")
                {
                    moneyOnHand += sum;
                    days++;
                    counter = 0;
                    if (moneyOnHand >= moneyVacation)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                    }
                }
                else if (action == "spend")
                {
                    days++;
                    if (moneyOnHand - sum <= 0)
                    {
                        moneyOnHand -= moneyOnHand;
                        counter++;
                    }
                    else
                    {
                        moneyOnHand -= sum;
                        counter++;
                    }
                }
            }

            if (counter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
        }
    }
}
