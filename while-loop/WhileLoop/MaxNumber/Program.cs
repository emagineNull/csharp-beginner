using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int k;
            int greater = int.MinValue;
            while (counter < n)
            {
                k = int.Parse(Console.ReadLine());
                if (k > greater)
                {
                    greater = k;
                }
                counter++;
            }

            Console.WriteLine(greater);
        }
    }
}
