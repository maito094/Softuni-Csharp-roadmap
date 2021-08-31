using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
   class Program
   {
      static void Main(string[] args)
      {
         List<int> random = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToList();


         for (int i = 0; i < random.Count; i++)
         {
            if (i == random.Count - 1)
            {
               break;
            }
            random[i] += random[random.Count - 1];
            random.RemoveAt(random.Count - 1);

         }
         Console.WriteLine(string.Join(" ", random));
      }
   }
}
