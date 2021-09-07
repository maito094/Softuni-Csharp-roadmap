using System;

namespace _02._Grades
{
   class Program
   {
      static void Main(string[] args)
      {
         double gradeNum = double.Parse(Console.ReadLine());

         PrintGrade(gradeNum);

      }

      private static void PrintGrade(double gradeNum)
      {
         if (gradeNum >= 2.00 && gradeNum <= 2.99)
         {
            Console.WriteLine("Fail");
         }
         else if (gradeNum >= 3.00 && gradeNum <= 3.49)
         {
            Console.WriteLine("Poor");
         }
         else if (gradeNum >= 3.50 && gradeNum <= 4.49)
         {
            Console.WriteLine("Good");
         }
         else if (gradeNum >= 4.50 && gradeNum <= 5.49)
         {
            Console.WriteLine("Very good");
         }
         else if (gradeNum >= 5.50 && gradeNum <= 6.00)
         {
            Console.WriteLine("Excellent");
         }
      }
   }
}
