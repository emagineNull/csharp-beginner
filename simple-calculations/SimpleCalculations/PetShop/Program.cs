using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsCount = int.Parse(Console.ReadLine());
            int otherAnimalsCount = int.Parse(Console.ReadLine());
          
            double bill = (dogsCount * 2.5) + (otherAnimalsCount * 4); 

            Console.WriteLine("{0:f2} lv.", bill);
        }
    }
}
