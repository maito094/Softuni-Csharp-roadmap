using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] numbers = Console.ReadLine().Split()
            .Select(int.Parse).ToArray();

         int sumOdd = 0;
         int sumEven = 0;

         foreach (var item in numbers)
         {
            if (item % 2 == 0)
            {
               sumEven += item;
            }
            else
            {
               sumOdd += item;
            }
         }
         Console.WriteLine((sumEven - sumOdd));
      }
   }
}
