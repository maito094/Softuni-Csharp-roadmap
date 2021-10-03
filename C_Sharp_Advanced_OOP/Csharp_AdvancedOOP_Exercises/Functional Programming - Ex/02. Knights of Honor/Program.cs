using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor
{
   class Program
   {
      static void Main(string[] args)
      {
         List<string> listKnights = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

         Action<List<string>> printNames = names => names.ForEach(k => Console.WriteLine($"Sir {k}"));

         printNames(listKnights);

      }
   }
}
