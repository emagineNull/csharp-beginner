using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());

            int time = 3 * projectsCount;

            if (projectsCount >= 1 && projectsCount <= 100)
            {
                Console.WriteLine($"The architect {architectName} will need {time} hours to" +
                    $" complete {projectsCount} project/s.");
            }
        }
    }
}
