using System;

namespace On_Time_for_the_Exam      // 2 fails => 87/100 score
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArriveExam = int.Parse(Console.ReadLine());
            int minuteArriveExam = int.Parse(Console.ReadLine());

            int hourDifference = 0;
            int minuteDifference = 0;

            int minutesTotalExam = minuteExam + hourExam * 60;
            int minutesTotalArriveExam = minuteArriveExam + hourArriveExam * 60;

            minuteDifference = (minutesTotalExam - minutesTotalArriveExam);
            hourDifference = Math.Abs((minutesTotalArriveExam / 60) - (minutesTotalExam / 60));

            #region Notworking
            //if (hourDifference <= 12 )
            ////1
            //// 0
            ////  23
            ////   0
            ////   Late
            ////    22:00 hours after the start
            //{
            //    if (hourExam < hourArriveExam)
            //    {
            //        hourExam += 24;
            //    }
            //    else
            //    {
            //        hourArriveExam += 24;
            //    }

            //    minutesTotalExam = minuteExam + hourExam * 60;
            //    minutesTotalArriveExam = minuteArriveExam + hourArriveExam * 60;

            //    minuteDifference = (minutesTotalExam - minutesTotalArriveExam);

            //    // exam 0:30 (arrive 12:00 ) =output Early 11:30, should be 12:30
            //    if (minuteExam >= minuteArriveExam)
            //    {
            //        hourDifference = Math.Abs((minutesTotalArriveExam / 60) - (minutesTotalExam / 60));
            //    }
            //    else
            //    {


            //        hourDifference = Math.Abs((minutesTotalArriveExam / 60) - (minutesTotalExam / 60)) - 1;


            //    }


            //}
            #endregion

            if (minutesTotalExam== minutesTotalArriveExam || minuteDifference==0)
            {
                Console.WriteLine("On time");
            }
            else if (minutesTotalArriveExam < minutesTotalExam ) 
            {
                

                if (minuteDifference/60 >=1)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hourDifference%24}:{(minuteDifference%60):00} hours before the start");
                }
                else if ( minuteDifference <= 30 && minuteDifference>=0)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minuteDifference} minutes before the start");
                }
                else if ( minuteDifference > 30 && minuteDifference<=59)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{minuteDifference} minutes before the start");
                }
             
            

            }
            else if (minutesTotalArriveExam > minutesTotalExam)
            {
                minuteDifference = Math.Abs(minuteDifference);

                if ( minuteDifference/60 >= 1)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hourDifference%24}:{minuteDifference%60:00} hours after the start");
                }

                else if (minuteDifference<=59 && minuteArriveExam>=0)
                {

             
                    Console.WriteLine("Late");
                    Console.WriteLine($"{(minuteDifference)} minutes after the start");
                   
                }
            }

                                 
        
        }
    }
}
