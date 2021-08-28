using System;

namespace OnTimefortheExam__v2  //Fail 5 =>62/100 score
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourStartExam = int.Parse(Console.ReadLine());
            int minuteStartExam = int.Parse(Console.ReadLine());
            int hourArriveExam = int.Parse(Console.ReadLine());
            int minuteArriveExam = int.Parse(Console.ReadLine());
            int diffMinutes = 0;
            int diffHours = 0;

            

            if (hourArriveExam==hourStartExam && minuteArriveExam==minuteStartExam)
            {
                Console.WriteLine("On time");
            }

            if (hourArriveExam<hourStartExam)       // Arrive Hour is Less than Start Exam hour
            {

                diffMinutes = Math.Abs(minuteArriveExam - (minuteStartExam + 60));

                if ( minuteArriveExam>=30 && minuteStartExam<=30)
                {
                    
                    if (diffMinutes<=30)
                    {
                        Console.WriteLine("On time");
                        Console.WriteLine($"{diffMinutes%60} minutes before the start"); 
                    }
                    else if (diffMinutes>30 && diffMinutes<=59)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{diffMinutes%60} minutes before the start");
                    }

                }
                else
                {
                    diffHours = hourStartExam - hourArriveExam;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{diffHours}:{diffMinutes%60:00} hours before the start");
                }
            }
            else if (hourArriveExam == hourStartExam)       // Arrive hour is Equal to Start hour
            {
                diffMinutes = minuteStartExam - minuteArriveExam;

                if (diffMinutes>0 && diffMinutes<=30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{diffMinutes} minutes before the start");
                }
                else if (diffMinutes > 0 && diffMinutes > 30 && diffMinutes<=59)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{diffMinutes%60} minutes before the start");
                }
                else if (diffMinutes < 0)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{Math.Abs(diffMinutes)%60} minutes after the start");
                }
            }
            else if (hourArriveExam > hourStartExam)
            {
                diffMinutes = minuteStartExam - (minuteArriveExam+60);
                diffHours = Math.Abs(hourStartExam - hourArriveExam);
                

                if (diffMinutes < 0 && diffMinutes>=-59)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{Math.Abs(diffMinutes)%60} minutes after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{diffHours}:{Math.Abs(diffMinutes) % 60:00} hours after the start");

                }
            }
        }
    }
}
