using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] originArray = Console.ReadLine().Split()
               .Select(int.Parse).ToArray();

         for (int i = 0; i < originArray.Length - 1; i++)
         {

            for (int j = 0; j < originArray.Length - 1 - i; j++)
            {
               originArray[j] += originArray[j + 1];
            }
         }
         Console.WriteLine(originArray[0]);
      }
   }
}
