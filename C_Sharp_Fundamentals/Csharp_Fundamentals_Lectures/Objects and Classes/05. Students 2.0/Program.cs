using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Students_2._0
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

            if (Student.IsStudentExisting(student, students))
            {
               students[students.FindIndex(s => s.Name == student.Name && s.LastName == student.LastName)] = student;
            }
            else
            {
               students.Add(student);

            }

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


      public static bool IsStudentExisting(Student student, List<Student> students)
      {
         if (students.FindAll(s => s.Name == student.Name && s.LastName == student.LastName).Count > 0)
         {

            return true;
         }
         else return false;
      }
   }
}
