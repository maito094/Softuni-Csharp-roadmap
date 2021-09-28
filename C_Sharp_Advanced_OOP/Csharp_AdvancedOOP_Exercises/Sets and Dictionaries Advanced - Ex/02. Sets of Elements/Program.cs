using System;
using System.Collections.Generic;

namespace _02._Sets_of_Elements
{
   class Program
   {
      static void Main(string[] args)
      {
         var numbers = Console.ReadLine().Split(" ");
         int n = int.Parse(numbers[0]);
         int m = int.Parse(numbers[1]);

         HashSet<int> setN = new HashSet<int>();
         HashSet<int> setM = new HashSet<int>();

         for (int i = 0; i < n + m; i++)
         {
            int number = int.Parse(Console.ReadLine());

            if (i < n)
            {
               setN.Add(number);
            }
            else
            {
               setM.Add(number);
            }
         }

         foreach (var nNumber in setN)
         {
            foreach (var mNumber in setM)
            {
               if (nNumber == mNumber)
               {
                  Console.Write(mNumber + " ");
               }
            }
         }

      }
   }
}
