using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());
            int counter = 0;
            int grade = 0;
            double sumGrades = 0;
            int gradeNumber = 0;
            string lastExercise = "";
            int problemNum = 0;

            while (counter < poorGrades)
            {
                string exercise = Console.ReadLine();
                if (exercise != "Enough")
                {
                    grade = int.Parse(Console.ReadLine());
                    problemNum++;
                    if (grade > 4)
                    {                        
                        sumGrades += grade;
                        lastExercise = exercise;
                        gradeNumber++;
                    }
                    else
                    {
                        sumGrades += grade;
                        lastExercise = exercise;
                        gradeNumber++;
                        counter++;
                    }
                }
                if (exercise == "Enough")
                {
                    Console.WriteLine($"Average score: {sumGrades * 1.0 / gradeNumber:f2}");
                    Console.WriteLine($"Number of problems: {problemNum}");
                    Console.WriteLine($"Last problem: {lastExercise}");
                    break;
                }
            }

            if (counter == poorGrades)
            {
                Console.WriteLine($"You need a break, {poorGrades} poor grades.");
            }
        }
    }
}
