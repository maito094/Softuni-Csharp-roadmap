using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            const int wholeYearWeekends = 48;
            string year = Console.ReadLine();       //leap = 15% more, normal = 0% more
            int p = int.Parse(Console.ReadLine());  //number of holidays (not saturdays or sundays)
            int h = int.Parse(Console.ReadLine());  //number of weekends in the year that Vladi goes to hometown

            double noWork_Sofia = 3.0 * (wholeYearWeekends - h)/4;

            double saturdayPlaySofia = noWork_Sofia + (2.0 * p / 3);
            double sundayPlayHometown = h;

            double playedTime = saturdayPlaySofia + sundayPlayHometown;
            if (year=="leap")
            {
                playedTime *= (1 + 0.15);
            }
            Console.WriteLine($"{Math.Floor(playedTime)}");
        }
    }
}
