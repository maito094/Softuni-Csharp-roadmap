using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

         Func<int[], int> getSmallestNumber = numbers =>
          {
             int minValue = int.MaxValue;

             foreach (var number in numbers)
             {
                if (number < minValue)
                {
                   minValue = number;
                }
             }

             return minValue;
          };

         Console.WriteLine(getSmallestNumber(numbers));
      }
   }
}
