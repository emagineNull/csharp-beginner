using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());

            double commissionPercent = 0.0;
            bool isInputValid = true;
            switch (town)
            {
                case "Sofia":
                    if (volume < 0)
                    {
                        isInputValid = false;
                    }
                    else if (volume >= 0 && volume <= 500)
                    {
                        commissionPercent = 0.05;
                    }
                    else if (volume > 500 && volume <= 1000)
                    {
                        commissionPercent = 0.07;
                    }
                    else if (volume > 1000 && volume <= 10000)
                    {
                        commissionPercent = 0.08;
                    }
                    else
                    {
                        commissionPercent = 0.12;
                    }
                    break;
                case "Varna":
                    if (volume < 0)
                    {
                        isInputValid = false;
                    }
                    else if (volume >= 0 && volume <= 500)
                    {
                        commissionPercent = 0.045;
                    }
                    else if (volume > 500 && volume <= 1000)
                    {
                        commissionPercent = 0.075;
                    }
                    else if (volume > 1000 && volume <= 10000)
                    {
                        commissionPercent = 0.1;
                    }
                    else
                    {
                        commissionPercent = 0.13;
                    }
                    break;
                case "Plovdiv":
                    if (volume < 0)
                    {
                        isInputValid = false;
                    }
                    else if (volume >= 0 && volume <= 500)
                    {
                        commissionPercent = 0.055;
                    }
                    else if (volume > 500 && volume <= 1000)
                    {
                        commissionPercent = 0.08;
                    }
                    else if (volume > 1000 && volume <= 10000)
                    {
                        commissionPercent = 0.12;
                    }
                    else
                    {
                        commissionPercent = 0.145;
                    }
                    break;
                default:
                    isInputValid = false;
                    break;
            }
            double commissionAmount = commissionPercent * volume;

            if (isInputValid)
            {
                Console.WriteLine($"{commissionAmount:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
