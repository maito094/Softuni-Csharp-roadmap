using System;

namespace Graduation
{
   class Program
   {
      static void Main(string[] args)
      {

         string student = Console.ReadLine();
         double yearlyGrade = 0;
         double averageGrade = 0;
         int failed = 0;
         int iYears = 0;

         do
         {
            yearlyGrade = double.Parse(Console.ReadLine());

            averageGrade += yearlyGrade;
            if (yearlyGrade < 4.00)
            {
               failed++;
            }
            iYears++;
            if (failed < 1 && iYears == 12)
            {
               Console.WriteLine($"{student} graduated. Average grade: {averageGrade / iYears:0.00}");
               break;

            }
            else if (failed >= 2)
            {
               Console.WriteLine($"{student} has been excluded at {iYears - 1} grade");
               break;

            }
         } while (iYears < 12);

      }
   }
}
