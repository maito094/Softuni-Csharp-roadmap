using System;

namespace SoftUni_Cs_Fund_Lectures_1
{
   class Program
   {
      static void Main(string[] args)
      {
         string name = Console.ReadLine();
         int age = int.Parse(Console.ReadLine());
         double aveGrade = double.Parse(Console.ReadLine());


         Console.WriteLine($"Name: {name}, Age: {age}, Grade: {aveGrade:f2}");
      }
   }
}
