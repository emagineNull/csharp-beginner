using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();

            double totalAvgGrade = 0;
            int counter = 0;

            while (presentation != "Finish")
            {
                double grade = 0;
                double averageGrade = 0;
                for (int i = 0; i < jury; i++)
                {
                    grade = double.Parse(Console.ReadLine());
                    averageGrade += grade;
                }

                averageGrade /= jury;
                totalAvgGrade += averageGrade;
                counter++;
                Console.WriteLine($"{presentation} - {averageGrade:f2}.");

                presentation = Console.ReadLine();
            }

            totalAvgGrade /= counter;
            Console.WriteLine($"Student's final assessment is {totalAvgGrade:f2}.");
        }
    }
}
