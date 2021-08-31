using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());

         string[] givenString = new string[2];
         int[] firstArr = new int[n];
         int[] secondArr = new int[n];

         for (int i = 0; i < n; i++)
         {
            givenString = Console.ReadLine().Split();

            if (i % 2 == 0)
            {
               firstArr[i] = int.Parse(givenString[0]);
               secondArr[i] = int.Parse(givenString[1]);
            }
            else
            {
               firstArr[i] = int.Parse(givenString[1]);
               secondArr[i] = int.Parse(givenString[0]);
            }

         }
         Console.WriteLine(string.Join(" ", firstArr));
         Console.WriteLine(string.Join(" ", secondArr));
      }
   }
}
