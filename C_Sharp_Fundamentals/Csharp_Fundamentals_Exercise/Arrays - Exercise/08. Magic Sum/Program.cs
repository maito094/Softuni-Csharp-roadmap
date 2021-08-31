using System;
using System.Linq;

namespace _08._Magic_Sum
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

         int numEqual = int.Parse(Console.ReadLine());
         bool isEqual = false;

         for (int i = 0; i < numbers.Length - 1; i++)
         {
            for (int j = i + 1; j < numbers.Length; j++)
            {
               if (numbers[i] + numbers[j] == numEqual)
               {

                  Console.Write($"{numbers[i]} {numbers[j]}");
                  isEqual = true;
               }
            }
            if (isEqual)
            {

               Console.WriteLine();
               isEqual = false;
            }

         }
      }
   }
}
