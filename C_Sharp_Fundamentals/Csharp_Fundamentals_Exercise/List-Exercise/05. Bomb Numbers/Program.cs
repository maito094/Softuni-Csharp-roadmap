using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.Bomb_Numbers
{
   class Program
   {
      static void Main(string[] args)
      {
         List<int> randomNum = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToList();

         int[] bombCoords = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToArray();

         int specialNum = bombCoords[0];
         int powerNum = bombCoords[1];

         int totalSum = 0;
         for (int i = 0; i < randomNum.Count; i++)
         {
            if (randomNum[i] == specialNum)
            {
               for (int j = i - powerNum; j <= i + powerNum; j++)
               {
                  if (j < 0)
                  {
                     continue;
                  }
                  else if (j > randomNum.Count - 1)
                  {
                     break;
                  }

                  randomNum[j] = 0;
               }
            }
         }
         foreach (var num in randomNum)
         {

            totalSum += num;
         }

         Console.WriteLine(totalSum);  // randomNum.Sum();
      }
   }
}
