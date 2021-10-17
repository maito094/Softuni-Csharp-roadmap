using System;
using System.Collections.Generic;

namespace ComparingObjects
{
   class Program
   {
      static void Main(string[] args)
      {
         List<Person> persons = new List<Person>();

         while (true)
         {
            var input = Console.ReadLine().Split();

            if (input[0] == "END")
            {
               break;
            }

            string personName = input[0];
            int personAge = int.Parse(input[1]);
            string personTown = input[2];
            persons.Add(new Person(personName, personAge, personTown));

         }

         var index = int.Parse(Console.ReadLine()) - 1;
         var equalPersons = 0;
         var notEqualPersons = 0;

         foreach (Person person in persons)
         {
            if (persons[index].CompareTo(person) == 0)
            {
               equalPersons++;

            }
            else
            {
               notEqualPersons++;
            }
         }

         if (equalPersons <= 1)
         {
            Console.WriteLine("No matches");
         }
         else
         {
            Console.WriteLine($"{equalPersons} {notEqualPersons} { persons.Count}");
         }

      }

   }

}
