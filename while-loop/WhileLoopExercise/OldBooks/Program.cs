using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int library = int.Parse(Console.ReadLine());

            int counter = 0;
            while (counter < library)
            {
                string bookSearch = Console.ReadLine();
                counter++;
                if (bookSearch == book)
                {
                    Console.WriteLine($"You checked {counter - 1} books and found it.");
                    break;
                }
                if (counter == library)
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                }
            }
        }
    }
}
