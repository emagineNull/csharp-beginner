using System;

namespace ConcatenateData
{
    class Program
    {
        static void Main(string[] args)
        {        
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            //Console.WriteLine("Hello, {0} {1}, aged {2}!", firstName, lastName, age);
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
