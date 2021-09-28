using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
   class Program
   {
      static void Main(string[] args)
      {

         string input = Console.ReadLine();

         SortedDictionary<char, int> characterValues = new SortedDictionary<char, int>();

         for (int i = 0; i < input.Length; i++)
         {
            if (characterValues.ContainsKey(input[i]))
            {

               characterValues[input[i]] += 1;
            }
            else
            {
               characterValues.Add(input[i], 1);
            }

         }

         foreach (var character in characterValues)
         {
            Console.WriteLine($"{character.Key}: {character.Value} time/s");
         }

      }
   }
}
