using System;
using System.Collections.Generic;

namespace DefiningClasses
{
   public class StartUp
   {
      public static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());
         Family family = new Family();

         for (int i = 0; i < n; i++)
         {
            string[] line = Console.ReadLine().Split(" ");
            string name = line[0];
            int age = int.Parse(line[1]);

            Person person = new Person(name, age);

            family.AddMember(person);
         }

         Person oldestPerson = family.GetOldestMember();

         Console.WriteLine(oldestPerson.Name + " "
            + oldestPerson.Age);
      }
   }
}
