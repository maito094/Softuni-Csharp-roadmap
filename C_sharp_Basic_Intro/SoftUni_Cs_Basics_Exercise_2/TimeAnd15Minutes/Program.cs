using System;

namespace TimeAnd15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int fixMinutes = 15;
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int toMinutesAll = hours * 60 + minutes + fixMinutes;
            int nextHours = toMinutesAll / 60;
            int nextMinutes = toMinutesAll % 60;
            if (nextHours>23)
            {
                nextHours = 0;
            }
            Console.WriteLine($"{nextHours}:{nextMinutes:00}");
        }
    }
}
