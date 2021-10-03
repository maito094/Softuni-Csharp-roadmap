using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());
         int[] divisionNumbers = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

         int[] numbersInRange = Enumerable.Range(1, n).ToArray();

         List<Predicate<int>> predicates = new List<Predicate<int>>();

         foreach (var number in divisionNumbers)
         {
            predicates.Add(x => x % number == 0);
         }

         foreach (var currentNumber in numbersInRange)
         {
            bool isDvisible = true;

            foreach (var predicate in predicates)
            {
               if (!predicate(currentNumber))
               {
                  isDvisible = false;
                  break;

               }
            }

            if (isDvisible)
            {
               Console.Write(currentNumber + " ");
            }
         }

      }
   }
}
