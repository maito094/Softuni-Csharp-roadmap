using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
   class Program
   {
      static void Main(string[] args)
      {
         Func<string, bool> upperCaseFirstLetter = word => char.IsUpper(word[0]);

         List<string> words = Console.ReadLine()
                                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                     .Where(upperCaseFirstLetter)
                                     .ToList();

         Console.WriteLine(string.Join("\n", words));

      }
   }
}
