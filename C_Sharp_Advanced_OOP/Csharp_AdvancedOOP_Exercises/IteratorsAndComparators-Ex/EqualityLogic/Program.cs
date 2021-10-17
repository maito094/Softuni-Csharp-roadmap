using System;
using System.Collections.Generic;

namespace EqualityLogic
{
   class Program
   {
      static void Main(string[] args)
      {
         SortedSet<Person> personSortedSet = new SortedSet<Person>();
         HashSet<Person> personHashSet = new HashSet<Person>();

         int numLines = int.Parse(Console.ReadLine());

         for (int i = 0; i < numLines; i++)
         {
            var tokens = Console.ReadLine().Split();
            var person = new Person(tokens[0], int.Parse(tokens[1]));
            personSortedSet.Add(person);
            personHashSet.Add(person);
         }

         Console.WriteLine(personSortedSet.Count);
         Console.WriteLine(personHashSet.Count);
      }

   }

}
