using System;

namespace OnTimeExam    // OK 100/100
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArriveExam = int.Parse(Console.ReadLine());
            int minuteArriveExam = int.Parse(Console.ReadLine());

            int minutesTotalExam = minuteExam + hourExam * 60;
            int minutesTotalArriveExam = minuteArriveExam + hourArriveExam * 60;

            int timeDifference = minutesTotalExam - minutesTotalArriveExam;

            int timeHour =Math.Abs( timeDifference) / 60;
            int timeMinute =Math.Abs( timeDifference) % 60;

            if (timeDifference>30)
            {
                
                Console.WriteLine("Early");
                if (timeHour>=1)
                {

                    Console.WriteLine($"{timeHour}:{(timeMinute):00} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{timeMinute} minutes before the start");
                }
               
            }
            else if (timeDifference<0)
            {
                Console.WriteLine("Late");
                int timeAbsolute = Math.Abs(timeDifference);

                if (timeAbsolute < 60)
                {
                    Console.WriteLine($"{timeMinute} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{timeHour}:{(timeMinute):00} hours after the start");
                }
            }

            else
            {
                Console.WriteLine("On Time");
                if (timeDifference > 0)
                {
                    Console.WriteLine($"{timeDifference} minutes before the start");
                }
            }
           
        }
    }
}
