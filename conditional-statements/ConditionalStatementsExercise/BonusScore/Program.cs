using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            double bonus;
            double total = 0;

            if (score <= 100)
            {
                bonus = 5;
            }
            else if (score > 100 && score <= 1000)
            {
                bonus = score * 0.2;
            }
            else
            {
                bonus = score * 0.1;
            }

            
            if (score % 2 == 0)
            {
                bonus += 1;
                total = score + bonus;
            }
            else if (score % 10 == 5)
            {
                bonus += 2;
                total = score + bonus;
            }
            else
            {
                total = score + bonus;
            }
            

            Console.WriteLine("{0}\n{1}", bonus, total);
        }
    }
}
