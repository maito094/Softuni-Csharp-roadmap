using System;

namespace _01._Binary_Digits_Count
{
   class Program
   {
      static void Main(string[] args)
      {
         int number = int.Parse(Console.ReadLine());
         int B = int.Parse(Console.ReadLine());
         int foundNumbersB = 0;
         while (number > 0)
         {
            if ((number % 2).Equals(B))
            {
               foundNumbersB++;
            }
            number /= 2;


         }
         Console.WriteLine(foundNumbersB);
      }
   }
}
