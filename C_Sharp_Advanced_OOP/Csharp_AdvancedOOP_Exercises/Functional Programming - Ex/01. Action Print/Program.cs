using System;
using System.Collections.Generic;

namespace _01._Action_Print
{
   class Program
   {
      static void Main(string[] args)
      {
         var listPeople = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

         Action<string[]> printNames = names => Console.WriteLine(string.Join(Environment.NewLine, names));

         printNames(listPeople);

      }
   }
}
