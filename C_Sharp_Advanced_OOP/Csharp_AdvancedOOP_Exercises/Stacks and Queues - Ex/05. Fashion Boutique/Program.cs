using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
   class Program
   {
      static void Main(string[] args)
      {

         Stack<int> clothesInBox = new Stack<int>(Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray());

         int capacity = int.Parse(Console.ReadLine());

         int sumClothing = 0;
         int numOfRacks = 1;

         while (clothesInBox.Count > 0)
         {

            var currentClothes = clothesInBox.Pop();

            if (sumClothing + currentClothes <= capacity)
            {
               sumClothing += currentClothes;
            }
            else
            {
               sumClothing = currentClothes;
               numOfRacks++;

            }

         }

         Console.WriteLine(numOfRacks);

      }
   }
}
