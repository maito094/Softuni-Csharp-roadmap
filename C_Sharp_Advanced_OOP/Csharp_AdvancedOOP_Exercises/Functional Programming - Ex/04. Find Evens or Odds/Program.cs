using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] range = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
         string operation = Console.ReadLine();

         Action<int[]> printNumbers = inputNumbers => Console.WriteLine(string.Join(" ", inputNumbers));
         Predicate<int> isOddOrEven = null;

         if (operation == "odd")
         {
            isOddOrEven = inputNumber => inputNumber % 2 != 0;
         }
         else if (operation == "even")
         {
            isOddOrEven = inputNumber => inputNumber % 2 == 0;
         }

         List<int> listOfNumbers = Enumerable.Range(range[0], range[1] - range[0] + 1).ToList();

         printNumbers(listOfNumbers.FindAll(isOddOrEven).ToArray());

      }
   }
}
