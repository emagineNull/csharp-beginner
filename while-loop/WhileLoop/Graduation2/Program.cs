using System;

namespace Graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int currentGrade = 1;
            double score;
            double sumGrades = 0;
            int failCounter = 0;

            while (currentGrade <= 12)
            {
                score = double.Parse(Console.ReadLine());
                if (score >= 4)
                {
                    sumGrades += score;
                    currentGrade++;
                }
                else
                {
                    failCounter++;
                    if (failCounter > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {currentGrade} grade");
                        return;
                    }
                }
            }
            
            double sumGradesAverage = sumGrades / 12;
            Console.WriteLine($"{name} graduated. Average grade: {sumGradesAverage:f2}");
        }
    }
}
