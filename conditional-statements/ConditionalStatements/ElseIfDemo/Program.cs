using System;

namespace ElseIfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // else if
            int num = int.Parse(Console.ReadLine());

            if (num % 3 == 0)
            {
                Console.WriteLine("{0} divides by 3 without remainder.", num);
            }
            else if (num % 3 == 1)
            {
                Console.WriteLine("{0} divides by 3 with a remainder of 1.", num);
            }
            else
            {
                Console.WriteLine("{0} divides by 3 with a remainder of 2.", num);
            }

            // more else if
            int num2 = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("divisible by 3 without a remainder");
            }
            else
            {
                Console.WriteLine("odd");
            }

            // life of a variable
            int num3 = int.Parse(Console.ReadLine());
            int doubledNum3 = num3 * 2;
            int tripledNum3 = num3 * 3;

            if (num3 % 2 == 0)
            {
                // int doubleNum3 = num3 * 2; Error!!!
                Console.WriteLine(doubledNum3);
            }
            else
            {
                // int tripledNum3 = num3 * 3; Error!
                Console.WriteLine(tripledNum3);
            }
        }
    }
}
