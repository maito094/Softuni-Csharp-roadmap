using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
   class Program
   {
      static void Main(string[] args)
      {
         int nPair = int.Parse(Console.ReadLine());

         Dictionary<string, double> studentGrade = new Dictionary<string, double>();

         for (int i = 0; i < nPair; i++)
         {
            //string[] input = Console.ReadLine().Split();
            string studentName = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            if (!studentGrade.ContainsKey(studentName))
            {
               studentGrade.Add(studentName, grade);
            }
            else
            {
               studentGrade[studentName] += grade;
               studentGrade[studentName] /= 2;

            }

         }
         studentGrade = studentGrade.Where(s => s.Value >= 4.50).OrderByDescending(o => o.Value).ToDictionary(k => k.Key, v => v.Value);

         foreach (var (name, grade) in studentGrade)
         {
            Console.WriteLine($"{name} -> {grade:F2}");

         }
      }
   }
}
