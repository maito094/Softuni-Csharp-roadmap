using System;

namespace _05._Sum_Even_Numbers
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] numString = Console.ReadLine().Split();

         int[] numbers = new int[numString.Length];
         int sum = 0;
         for (int i = 0; i < numbers.Length; i++)
         {
            numbers[i] = int.Parse(numString[i]);
            if (numbers[i] % 2 == 0)
            {
               sum += numbers[i];
            }
         }

         Console.WriteLine(sum);
      }
   }
}
