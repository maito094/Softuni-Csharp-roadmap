using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Append_Arrays
{
   class Program
   {
      static void Main(string[] args)
      {

         List<string[]> numbersList = Console.ReadLine()
            .Split("|")
            .Select(x => x.Split(" ", StringSplitOptions.RemoveEmptyEntries))
            .ToList();

         for (int j = numbersList.Count - 1; j >= 0; j--)
         {

            for (int i = 0; i < numbersList[j].Length; i++)
            {
               string helperString = string.Concat(numbersList[j].ElementAt(i), " ");
               Console.Write(helperString);

            }
         }
      }
   }
}
