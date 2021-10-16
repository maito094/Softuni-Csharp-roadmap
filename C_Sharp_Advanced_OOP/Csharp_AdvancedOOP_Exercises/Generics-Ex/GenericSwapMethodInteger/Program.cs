using System;
using System.Collections.Generic;

namespace GenericSwapMethodInteger
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());
         Box<int> box = new Box<int>();

         for (int i = 0; i < n; i++)
         {
            box.Item.Add(int.Parse(Console.ReadLine()));
         }

         var swapCommandParameters = Console.ReadLine().Split(" ");

         int firstElement = int.Parse(swapCommandParameters[0]);
         int secondElement = int.Parse(swapCommandParameters[1]);

         box.SwapListElements(box.Item, firstElement, secondElement);

         Console.WriteLine(box.ToString());

      }

   }

}
