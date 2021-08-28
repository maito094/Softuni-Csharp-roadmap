using System;

namespace Exam_Preparation
{
   class Program
   {
      static void Main(string[] args)
      {
         int insufficientNumGrade = int.Parse(Console.ReadLine());
         int numInsufficientGrade = 0;
         string problem = "";
         string lastProblem = "";
         int grade = 0;
         double aveGrade = 0;
         int numex = 0;
         while (true)
         {
            problem = Console.ReadLine();

            if (problem == "Enough")
            {
               Console.WriteLine($"Average score: {aveGrade / numex:0.00}");
               Console.WriteLine($"Number of problems: {numex}");
               Console.WriteLine($"Last problem: {lastProblem}");
               break;
            }
            else if (grade <= 4 && grade >= 2)
            {
               numInsufficientGrade++;

               if (numInsufficientGrade == insufficientNumGrade)
               {
                  Console.WriteLine($"You need a break, {insufficientNumGrade} poor grades.");
                  break;
               }

            }
            grade = int.Parse(Console.ReadLine());
            aveGrade += grade;
            numex++;
            lastProblem = problem;
         }

      }
   }
}
