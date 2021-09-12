using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
   class Program
   {
      static void Main(string[] args)
      {

         string[] words = Console.ReadLine().ToLower().Split();

         Dictionary<string, int> wordSequence = new Dictionary<string, int>();

         for (int i = 0; i < words.Length; i++)
         {
            if (!wordSequence.ContainsKey(words[i]))
            {
               wordSequence.Add(words[i], 0);
            }
            wordSequence[words[i]]++;
         }

         wordSequence = wordSequence.Where(w => w.Value % 2 != 0).ToDictionary(k => k.Key, v => v.Value);
         Console.WriteLine(string.Join(" ", wordSequence.Keys));

      }
   }
}
