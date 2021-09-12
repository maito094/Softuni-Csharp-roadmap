using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
   class Program
   {
      static void Main(string[] args)
      {

         string[] input = Console.ReadLine().Split(" : ");

         Dictionary<string, List<string>> studentCourses = new Dictionary<string, List<string>>();

         while (input[0] != "end")
         {
            string courseName = input[0];
            string studentName = input[1];

            if (!studentCourses.ContainsKey(courseName))
            {
               studentCourses.Add(courseName, new List<string>());
            }
            studentCourses[courseName].Add(studentName);

            input = Console.ReadLine().Split(" : ");
         }

         studentCourses = studentCourses.OrderByDescending(o => o.Value.Count).ToDictionary(k => k.Key, v => v.Value.OrderBy(o => o).ToList());

         foreach (var course in studentCourses)
         {
            Console.WriteLine($"{course.Key}: {course.Value.Count}");


            for (int i = 0; i < course.Value.Count; i++)
            {

               Console.WriteLine($"-- {course.Value[i]}");
            }

         }


      }
   }
}
