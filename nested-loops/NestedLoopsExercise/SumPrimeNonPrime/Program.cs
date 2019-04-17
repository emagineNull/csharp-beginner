using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int primeNumSum = 0;
            int nonPrimeNumSum = 0;
            while (command != "stop")
            {
                int number = int.Parse(command);
                bool prime = true;

                if (number == 1)
                {
                    prime = false;
                }

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    command = Console.ReadLine();
                    continue;
                }

                for (int i = number; i > 1; i--)
                {
                    if (number % i == 0 && i != number)
                    {
                        prime = false;
                        break;
                    }
                }
                
                if (prime)
                {
                    primeNumSum += number;
                }
                else
                {
                    nonPrimeNumSum += number;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeNumSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumSum}");
        }
    }
}
