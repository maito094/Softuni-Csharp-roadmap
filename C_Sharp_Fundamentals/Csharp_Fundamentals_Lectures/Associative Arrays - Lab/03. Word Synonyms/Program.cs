﻿using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());

         Dictionary<string, List<string>> synonymDictionary = new Dictionary<string, List<string>>();

         for (int i = 0; i < n; i++)
         {

            string word = Console.ReadLine();
            string synonym = Console.ReadLine();

            if (!synonymDictionary.ContainsKey(word))
            {
               synonymDictionary.Add(word, new List<string>());

            }
            synonymDictionary[word].Add(synonym);

         }

         foreach (var item in synonymDictionary)
         {
            Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
         }
      }
   }
}
