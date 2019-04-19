using System;

namespace CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            double voucher = double.Parse(Console.ReadLine());

            int price = 0;
            int tickets = 0;
            int otherProducts = 0;
            string command = string.Empty;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                if (command.Length > 8)
                {
                    price = command[0] + command[1];
                    if (voucher < price)
                    {
                        break;
                    }
                    voucher -= price;
                    tickets++;
                }
                else if (command.Length <= 8)
                {
                    price = command[0];
                    if (voucher < price)
                    {
                        break;
                    }
                    voucher -= price;
                    otherProducts++;
                }

            }

            Console.WriteLine(tickets);
            Console.WriteLine(otherProducts);
        }
    }
}
