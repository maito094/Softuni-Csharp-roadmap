using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Merging_Lists
{
   class Program
   {
      static void Main(string[] args)
      {
         List<int> firstList = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToList();
         List<int> secondList = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToList();

         List<int> resultList = new List<int>();


         bool isFirstBigger = false;
         bool isSecondBigger = false;
         int smallestList = firstList.Count;
         int biggestList = 0;


         if (firstList.Count > secondList.Count)
         {
            isFirstBigger = true;
            smallestList = secondList.Count;
            biggestList = firstList.Count;
         }
         else
         {
            isSecondBigger = true;
            smallestList = firstList.Count;
            biggestList = secondList.Count;
         }

         for (int i = 0; i < smallestList; i++)
         {
            resultList.Add(firstList[i]);
            resultList.Add(secondList[i]);

         }

         if ((isFirstBigger ^ isSecondBigger) == true)
         {
            for (int i = smallestList; i < biggestList; i++)
            {
               if (isFirstBigger)
               {
                  resultList.Add(firstList[i]);
               }
               else
               {
                  resultList.Add(secondList[i]);
               }
            }
         }

         Console.WriteLine(string.Join(" ", resultList));
      }
   }
}
