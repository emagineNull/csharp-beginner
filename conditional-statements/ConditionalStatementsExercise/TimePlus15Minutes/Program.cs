using System;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            
            if (minutes >= 45 && hour != 23)
            {
                hour += 1;
                minutes -= 45;
            }
            else if (minutes >= 45 && hour == 23)
            {
                hour = 0;
                minutes -= 45;
            }
            else 
            {
                minutes += 15;
            }


            if (minutes < 10)
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes}");
            }
        }
    }
}
