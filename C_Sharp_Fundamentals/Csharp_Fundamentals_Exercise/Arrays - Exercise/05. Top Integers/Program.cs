using System;

namespace _05._Top_Integers
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] input = Console.ReadLine().Split();
         int[] topIntegers = new int[input.Length];
         int j = 0;

         for (int i = input.Length - 1; i >= 0; i--)
         {
            if ((int.Parse(input[i]) > topIntegers[input.Length - 1]) && (int.Parse(input[i - 1]) != int.Parse(input[i])))
            {
               topIntegers[input.Length - 1 - j] = int.Parse(input[i]);
               j++;
            }
         }
         for (int k = input.Length - j; k < input.Length; k++)
         {
            Console.Write($"{topIntegers[k]} ");
         }

      }
   }
}
