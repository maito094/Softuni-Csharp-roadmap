using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._Students
{
   class Program
   {
      static void Main(string[] args)
      {
         //first name, last name, age and hometown. 

         string[] fullInput = Console.ReadLine().Split();

         List<Student> students = new List<Student>();
         while (fullInput[0] != "end")
         {
            Student student = new Student(fullInput[0], fullInput[1], fullInput[2], fullInput[3]);

            students.Add(student);

            fullInput = Console.ReadLine().Split();
         }

         string filterTown = Console.ReadLine();

         List<Student> filteredStudents = students
                                          .Where(s => s.HomeTown == filterTown)
                                          .ToList();

         foreach (var student in filteredStudents)
         {
            Console.WriteLine($"{student.Name} {student.LastName} is {student.Age} years old.");
         }

      }
   }
   class Student
   {
      public string Name { get; set; }
      public string LastName { get; set; }
      public string Age { get; set; }
      public string HomeTown { get; set; }

      public Student(string name, string lastName, string age, string homeTown)
      {
         Name = name;
         LastName = lastName;
         Age = age;
         HomeTown = homeTown;
      }
   }
}
