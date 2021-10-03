using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
   class Person
   {
      public string Name;
      public int Age;
   }

   class Program
   {
      static void Main(string[] args)
      {

         int n = int.Parse(Console.ReadLine());

         List<Person> people = new List<Person>();

         for (int i = 0; i < n; i++)
         {
            string line = Console.ReadLine();
            var parts = line.Split(", ");
            string name = parts[0];
            int age = int.Parse(parts[1]);

            var person = new Person();
            person.Name = name;
            person.Age = age;

            people.Add(person);

         }

         var filterName = Console.ReadLine();   //younger /older 
         var ageToCompareWith = int.Parse(Console.ReadLine());


         Func<Person, bool> filter = p => true;
         if (filterName == "younger")
         {
            filter = p => p.Age < ageToCompareWith;
         }
         else if (filterName == "older")
         {
            filter = p => p.Age >= ageToCompareWith;
         }

         var filteredPeople = people.Where(filter);

         var printName = Console.ReadLine();

         Func<Person, string> printFunc = p => p.Name + " " + p.Age;

         if (printName == "name age")
         {
            printFunc = p => p.Name + " - " + p.Age;
         }
         else if (printName == "name")
         {
            printFunc = p => p.Name;
         }
         else if (printName == "age")
         {
            printFunc = p => p.Age.ToString();
         }

         var personAsString = filteredPeople.Select(printFunc);

         foreach (var str in personAsString)
         {
            Console.WriteLine(str);
         }
      }
   }
}
