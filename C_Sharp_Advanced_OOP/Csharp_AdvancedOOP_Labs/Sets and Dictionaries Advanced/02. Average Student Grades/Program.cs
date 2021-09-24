using System;
using System.Collections.Generic;

namespace _02._Average_Student_Grades
{
   class Program
   {
      static void Main(string[] args)
      {

         int countGrades = int.Parse(Console.ReadLine());
         Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();


         for (int i = 0; i < countGrades; i++)
         {
            var line = Console.ReadLine().Split(' ');
            string name = line[0];
            decimal grade = decimal.Parse(line[1]);


            if (!students.ContainsKey(name))
            {
               students.Add(name, new List<decimal> { grade });
            }
            else
            {
               students[name].Add(grade);
            }
         }

         foreach (var student in students)
         {
            decimal averageGrade = 0;
            Console.Write($"{student.Key} -> ");

            foreach (var grade in student.Value)
            {
               averageGrade += grade;
               Console.Write($"{grade:f2} ");
            }
            averageGrade /= student.Value.Count;
            Console.WriteLine($"(avg: {averageGrade:f2})");
         }

      }
   }
}
