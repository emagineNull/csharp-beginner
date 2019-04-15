using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int currentGrade = 1;
            int countGrades = 0;
            double sumGrades = 0;
            double sumGradesAverage = 0;

            double score;

            while (currentGrade <= 12)
            {
                score = double.Parse(Console.ReadLine());
                if (score >= 4)
                {
                    sumGrades += score;
                    countGrades++;
                    currentGrade++;
                }
            }

            sumGradesAverage = sumGrades / countGrades;

            Console.WriteLine($"{name} graduated. Average grade: {sumGradesAverage:f2}");
        }
    }
}
