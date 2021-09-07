using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Randomize_Words
{
   class Program
   {
      static void Main(string[] args)
      {
         List<string> words = Console.ReadLine().Split()
                                                .ToList();

         Random randomWord = new Random();

         for (int i = 0; i < words.Count; i++)
         {
            int randomNum = randomWord.Next(words.Count);
            string tmpWord = words[i];
            words[i] = words[randomNum];
            words[randomNum] = tmpWord;
         }
         Console.Write(string.Join(Environment.NewLine, words));

      }
   }
}
