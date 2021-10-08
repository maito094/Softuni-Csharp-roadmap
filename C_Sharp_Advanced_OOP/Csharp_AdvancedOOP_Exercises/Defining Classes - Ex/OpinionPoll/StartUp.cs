using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
   {
      public static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());

         List<Person> people = new List<Person>();

         for (int i = 0; i < n; i++)
         {
            string[] line = Console.ReadLine().Split(" ");
            string name = line[0];
            int age = int.Parse(line[1]);

            Person person = new Person(name, age);
            people.Add(person);
         }

         people = people.OrderBy(x => x.Name).Where(p => p.Age > 30).ToList();

         foreach (var person in people)
         {
            Console.WriteLine($"{person.Name} - {person.Age}");
         }

      }
   }
}
