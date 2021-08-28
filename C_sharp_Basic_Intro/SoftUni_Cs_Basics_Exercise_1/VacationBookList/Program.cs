using System;

namespace VacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int cntDays = int.Parse(Console.ReadLine());
            double hoursPerDay = cntPages/pagesPerHour/ cntDays;
            Console.WriteLine(hoursPerDay);
        }
    }
}
