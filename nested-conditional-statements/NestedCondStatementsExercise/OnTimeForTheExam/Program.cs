using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minArrival = int.Parse(Console.ReadLine());

            int beforeStartHour;
            int beforeStartMin;
            int afterStartHour;
            int afterStartMin;

            
            if (hourArrival == 0)
            {
                hourArrival = 24;
            }
            else if (hourExam == 0)
            {
                hourExam = 24;
            }

            if (hourArrival < hourExam || minArrival < minExam) // Early
            {
                if (hourArrival == hourExam)
                {
                    beforeStartMin = Math.Abs(minExam - minArrival);
                    beforeStartHour = hourExam;
                }
                else if (minArrival == minExam)
                {
                    beforeStartMin = minExam;
                    beforeStartHour = hourExam - hourArrival;
                }
                else
                {                   
                    if (hourArrival == hourExam - 1 && minArrival > minExam)
                    {
                        beforeStartMin = 60 - minArrival + minExam;
                        beforeStartHour = 0;
                    }
                    else
                    {
                        beforeStartHour = hourExam - hourArrival;
                        beforeStartMin = Math.Abs(minArrival - minExam);
                    }
                }
                Console.WriteLine("Early");
                if (hourArrival + 1 < hourExam && minArrival > minExam)
                {
                    if (beforeStartMin < 10)
                    {
                        Console.WriteLine($"{beforeStartHour}:0{beforeStartMin} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{beforeStartHour}:{beforeStartMin} hours before the start");
                    }
                }
                else
                {
                    if (beforeStartMin < 10)
                    {
                        Console.WriteLine($"{beforeStartMin} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{beforeStartMin} minutes before the start");
                    }
                }
            }
            else if (hourArrival == hourExam && minArrival == minExam)
            {
                Console.WriteLine("On time");
            }
            else if (hourArrival > hourExam || minArrival > minExam)
            {
                if (hourArrival == hourExam)
                {
                    afterStartMin = Math.Abs(minExam - minArrival);
                    afterStartHour = hourExam;
                }
                else if (minArrival == minExam)
                {
                    afterStartHour = hourArrival - hourExam;
                    afterStartMin = minArrival;
                }
                else
                {
                    if (hourArrival == hourExam + 1 && minExam > minArrival)
                    {
                        afterStartMin = 60 - minExam + minArrival;
                        afterStartHour = 0 ;
                    }
                    else
                    {
                        afterStartHour = hourArrival - hourExam;
                        afterStartMin = Math.Abs(minArrival - minExam);
                    }
                }
                Console.WriteLine("Late");
                if (hourArrival + 1 < hourExam && minArrival < minExam)
                {
                    if (afterStartMin < 10)
                    {
                        Console.WriteLine($"{afterStartHour}:0{afterStartMin} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{afterStartHour}:{afterStartMin} hours after the start");
                    }
                }
                else if (hourArrival < hourExam)
                {
                    if (afterStartMin < 10)
                    {
                        Console.WriteLine($"{afterStartHour}:0{afterStartMin} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{afterStartHour}:{afterStartMin} hours after the start");
                    }
                }
                else
                {
                    if (afterStartMin < 10)
                    {
                        Console.WriteLine($"{afterStartMin} minutes after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{afterStartMin} minutes after the start");
                    }
                }
            }
        }
    }
}
