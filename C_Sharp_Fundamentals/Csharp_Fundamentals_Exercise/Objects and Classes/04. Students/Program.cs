using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Students
{
   class Program
   {
      static void Main(string[] args)
      {
         //List<int> random = Console.ReadLine()
         //                 .Split()
         //                 .Select(int.Parse)
         //                 .ToList();

         int countOfStudents = int.Parse(Console.ReadLine());
         List<Student> studentClass = new List<Student>();

         for (int i = 0; i < countOfStudents; i++)
         {
            string[] input = Console.ReadLine().Split();
            Student currentStudent = new Student(input[0], input[1], double.Parse(input[2]));
            studentClass.Add(currentStudent);
         }

         studentClass = studentClass.OrderByDescending(o => o.Grade).ToList();

         foreach (var student in studentClass)
         {
            Console.WriteLine(student.ToString());
         }
      }
   }
   class Student
   {
      public string Name { get; set; }
      public string LastName { get; set; }
      public double Grade { get; set; }

      public Student(string name, string lastName, double grade)
      {
         Name = name;
         LastName = lastName;
         Grade = grade;
      }

      public override string ToString()
      {
         return $"{Name} {LastName}: {Grade:f2}";
      }
   }
}
