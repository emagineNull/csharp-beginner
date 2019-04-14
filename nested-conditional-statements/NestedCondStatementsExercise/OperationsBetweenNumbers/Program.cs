using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = 0.0;

            if (n2 == 0 && (operation == "/" || operation == "%"))
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
                return;
            }
            else
            {
                switch (operation)
                {
                    case "+":
                        result = n1 + n2;
                        break;
                    case "-":
                        result = n1 - n2;
                        break;
                    case "*":
                        result = n1 * n2;
                        break;
                    case "/":
                        result = (n1 * 1.0) / n2;
                        break;
                    case "%":
                        result = n1 % n2;
                        break;
                    default:
                        break;
                }
            }

            bool evenOrOdd = operation == "+" || operation == "-" || operation == "*";
            string evenOrOdd2 = " ";
            if (evenOrOdd)
            {
                if (result % 2 == 0)
                {
                    evenOrOdd2 = "even";
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - {evenOrOdd2}");
                }
                else
                {
                    evenOrOdd2 = "odd";
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - {evenOrOdd2}");
                }
            }
            else if (operation == "/" && n2 != 0)
            {
                Console.WriteLine($"{n1} {operation} {n2} = {result:f2}");
            }
            else
            {
                Console.WriteLine($"{n1} {operation} {n2} = {result}");
            }
        }
    }
}
