using System;
using System.Linq;

namespace _05._Odd_Times
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] Numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

         int result = 0;
         for (int i = 0; i < Numbers.Length; i++)
         {
            result ^= Numbers[i]; //1 2 3 2 3 1 3 
         }
         Console.WriteLine(result);
      }
   }
}
