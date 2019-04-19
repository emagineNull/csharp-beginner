using System;

namespace OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string hall = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            if (movie == "A Star Is Born")
            {
                if (hall == "normal")
                {
                    Console.WriteLine($"{movie} -> {tickets * 7.5:f2} lv.");
                }
                else if (hall == "luxury")
                {
                    Console.WriteLine($"{movie} -> {tickets * 10.5:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"{movie} -> {tickets * 13.5:f2} lv.");
                }
            }
            else if (movie == "Bohemian Rhapsody")
            {
                if (hall == "normal")
                {
                    Console.WriteLine($"{movie} -> {tickets * 7.35:f2} lv.");
                }
                else if (hall == "luxury")
                {
                    Console.WriteLine($"{movie} -> {tickets * 9.45:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"{movie} -> {tickets * 12.75:f2} lv.");
                }
            }
            if (movie == "Green Book")
            {
                if (hall == "normal")
                {
                    Console.WriteLine($"{movie} -> {tickets * 8.15:f2} lv.");
                }
                else if (hall == "luxury")
                {
                    Console.WriteLine($"{movie} -> {tickets * 10.25:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"{movie} -> {tickets * 13.25:f2} lv.");
                }
            }
            if (movie == "The Favourite")
            {
                if (hall == "normal")
                {
                    Console.WriteLine($"{movie} -> {tickets * 8.75:f2} lv.");
                }
                else if (hall == "luxury")
                {
                    Console.WriteLine($"{movie} -> {tickets * 11.55:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"{movie} -> {tickets * 13.95:f2} lv.");
                }
            }
        }
    }
}
