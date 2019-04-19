using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = string.Empty;
            double seats = 0;
            int totalTickets = 0;
            double student = 0;
            double standard = 0;
            double kid = 0;
            int totalTicketsperMovie = 0;
            string ticketType = string.Empty;

            while (true)
            {
                movieName = Console.ReadLine();
                if (movieName == "Finish")
                {
                    break;
                }
                seats = double.Parse(Console.ReadLine());
                while (seats > totalTicketsperMovie)
                {
                    ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    if (ticketType == "student")
                    {
                        student++;
                    }
                    else if (ticketType == "standard")
                    {
                        standard++;
                    }
                    else if (ticketType == "kid")
                    {
                        kid++;
                    }
                    totalTickets++;
                    totalTicketsperMovie++;
                }
                double procentFull = (totalTicketsperMovie / seats) * 100.0;
                Console.WriteLine($"{movieName} - {procentFull:f2}% full.");

                totalTicketsperMovie = 0;
            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{student / totalTickets * 100.0:f2}% student tickets.");
            Console.WriteLine($"{standard / totalTickets * 100.0:f2}% standard tickets.");
            Console.WriteLine($"{kid / totalTickets * 100.0:f2}% kids tickets.");
        }
    }
}
