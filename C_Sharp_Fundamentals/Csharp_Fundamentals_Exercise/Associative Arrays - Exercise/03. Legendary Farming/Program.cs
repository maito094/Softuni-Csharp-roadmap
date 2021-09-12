using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
   class Program
   {
      static void Main(string[] args)
      {

         Dictionary<string, Legendary> legendaryItems = new Dictionary<string, Legendary>();
         legendaryItems["shards"] = new Legendary(0, "Shadowmourne");       //Shadowmourne
         legendaryItems["fragments"] = new Legendary(0, "Valanyr"); ;    //Valanyr
         legendaryItems["motes"] = new Legendary(0, "Dragonwrath"); ;        //Dragonwrath
         Dictionary<string, int> junkItems = new Dictionary<string, int>();

         while (true)
         {
            bool isFarmed = false;
            string[] input = Console.ReadLine().ToLower().Split();

            for (int i = 0; i < input.Length; i += 2)
            {
               if (legendaryItems.ContainsKey(input[i + 1]))
               {
                  legendaryItems[input[i + 1]].Materials += int.Parse(input[i]);

                  if (legendaryItems[input[i + 1]].Materials >= 250)
                  {
                     isFarmed = true;
                     Console.WriteLine($"{legendaryItems[input[i + 1]].LegendaryItem} obtained!");
                     legendaryItems[input[i + 1]].Materials -= 250;
                     break;
                  }
               }
               else
               {
                  if (!junkItems.ContainsKey(input[i + 1]))
                  {
                     junkItems.Add(input[i + 1], 0);
                  }
                  junkItems[input[i + 1]] += int.Parse(input[i]);
               }
            }

            if (isFarmed)
            {
               break;
            }
         }

         legendaryItems = legendaryItems.OrderByDescending(o => o.Value.Materials).ThenBy(t => t.Key).ToDictionary(k => k.Key, v => v.Value);

         foreach (var item in legendaryItems)
         {

            Console.WriteLine(string.Join("\n", $"{item.Key}: {item.Value.Materials}"));
         }

         junkItems = junkItems.OrderBy(o => o.Key).ToDictionary(k => k.Key, v => v.Value);

         foreach (var item in junkItems)
         {
            Console.WriteLine(string.Join("\n", $"{item.Key}: {item.Value}"));
         }

      }
   }

   class Legendary
   {
      public int Materials { get; set; }
      public string LegendaryItem { get; set; }

      public Legendary(int materials, string legendary)
      {
         Materials = materials;
         LegendaryItem = legendary;
      }
   }
}
