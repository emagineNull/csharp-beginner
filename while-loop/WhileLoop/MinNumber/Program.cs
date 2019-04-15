using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int min = int.MaxValue;
            int k;

            while (counter < n)
            {
                k = int.Parse(Console.ReadLine());

                if (k < min)
                {
                    min = k;
                }

                counter++;
            }

            Console.WriteLine(min);
        }
    }
}
