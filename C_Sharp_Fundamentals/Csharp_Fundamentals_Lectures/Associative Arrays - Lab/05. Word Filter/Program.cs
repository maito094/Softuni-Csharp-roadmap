using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Word_Filter
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] words = Console.ReadLine().Split();

         Dictionary<string, int> filterWords = new Dictionary<string, int>();

         for (int i = 0; i < words.Length; i++)
         {
            if (filterWords.ContainsKey(words[i]))
            {
               filterWords.Add(words[i], 0);
            }
            filterWords[words[i]] = words[i].Length;
         }

         Console.WriteLine(string.Join("\n", filterWords.Where(w => w.Value % 2 == 0).Select(s => s.Key)));
      }
   }
}
