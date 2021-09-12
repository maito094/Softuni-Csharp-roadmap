using System;
using System.Collections.Generic;

namespace _1._Count_Chars_in_a_String
{
   class Program
   {
      static void Main(string[] args)
      {
         Dictionary<char, int> chars = new Dictionary<char, int>();

         string[] input = Console.ReadLine().Split();

         for (int i = 0; i < input.Length; i++)
         {
            for (int j = 0; j < input[i].Length; j++)
            {

               if (!chars.ContainsKey(input[i][j]))
               {
                  chars.Add(input[i][j], 0);
               }
               chars[input[i][j]]++;
            }
         }

         foreach (var item in chars)
         {
            Console.WriteLine(string.Join("\n", $"{item.Key} -> {item.Value}"));

         }
      }
   }
}
