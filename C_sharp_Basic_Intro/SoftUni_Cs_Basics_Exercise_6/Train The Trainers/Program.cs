using System;

namespace Train_The_Trainers
{
   class Program
   {
      static void Main(string[] args)
      {
         int judges = int.Parse(Console.ReadLine());
         double aveGradePresentation = 0;
         double aveGradeStudent = 0;
         double numPresentations = 0;
         string presentation = Console.ReadLine();

         while (presentation != "Finish")
         {
            numPresentations++;
            aveGradePresentation = 0;
            for (int i = 1; i <= judges; i++)
            {
               aveGradePresentation += double.Parse(Console.ReadLine());

            }

            aveGradePresentation = aveGradePresentation / judges;

            aveGradeStudent += aveGradePresentation;

            Console.WriteLine($"{presentation} - {aveGradePresentation:f2}.");
            presentation = Console.ReadLine();
         }
         aveGradeStudent = aveGradeStudent / numPresentations;
         Console.WriteLine($"Student's final assessment is {aveGradeStudent:f2}.");
      }
   }
}
