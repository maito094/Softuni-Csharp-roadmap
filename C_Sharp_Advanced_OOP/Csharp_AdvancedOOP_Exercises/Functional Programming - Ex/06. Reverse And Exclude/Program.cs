using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
   class Program
   {
      static void Main(string[] args)
      {
         Func<int, int, bool> isDivisible = (dividend, divisor) => dividend % divisor == 0;

         int[] inputNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

         int divisorNumber = int.Parse(Console.ReadLine());

         int[] result = inputNumbers.Where(x => !isDivisible(x, divisorNumber))
                                    .Reverse()
                                    .ToArray();

         Console.WriteLine(string.Join(" ", result));
      }
   }
}
