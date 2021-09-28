using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
   class Program
   {
      static void Main(string[] args)
      {

         int nLinesOfClothes = int.Parse(Console.ReadLine());

         Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

         for (int i = 0; i < nLinesOfClothes; i++)
         {
            var inputLine = Console.ReadLine().Split(" -> ");

            string color = inputLine[0];
            string[] clothes = inputLine[1].Split(",");

            if (!wardrobe.ContainsKey(color))
            {
               wardrobe.Add(color, new Dictionary<string, int>());
            }

            foreach (var clothe in clothes)
            {
               if (!wardrobe[color].ContainsKey(clothe))
               {
                  wardrobe[color].Add(clothe, 0);
               }

               wardrobe[color][clothe] += 1;

            }
         }

         string[] pickedClothe = Console.ReadLine().Split(" ");

         foreach (var color in wardrobe.Keys)
         {
            Console.WriteLine($"{color} clothes:");

            foreach (var clothe in wardrobe[color])
            {
               bool isFound = color == pickedClothe[0] && clothe.Key == pickedClothe[1];
               string FoundClothe = isFound ? "(found!)" : "";
               Console.WriteLine($"* {clothe.Key} - {clothe.Value} {FoundClothe}");
            }
         }
      }
   }
}
