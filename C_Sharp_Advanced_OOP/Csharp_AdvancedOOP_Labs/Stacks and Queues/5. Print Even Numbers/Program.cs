using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] arrayNums = Console.ReadLine()
                                  .Split(" ")
                                  .Select(int.Parse)
                                  .ToArray();

         Queue<int> numberStack = new Queue<int>();

         for (int i = 0; i < arrayNums.Length; i++)
         {
            if (arrayNums[i] % 2 == 0)
            {
               numberStack.Enqueue(arrayNums[i]);
            }
         }

         while (numberStack.Count > 1)
         {
            Console.Write(numberStack.Dequeue() + ", ");
         }
         Console.WriteLine(numberStack.Dequeue());

      }
   }
}
