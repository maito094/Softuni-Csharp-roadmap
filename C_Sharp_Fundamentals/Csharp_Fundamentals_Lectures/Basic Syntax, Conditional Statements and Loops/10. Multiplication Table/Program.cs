using System;

namespace _10._Multiplication_Table
{
   class Program
   {
      static void Main(string[] args)
      {
         int multiple = int.Parse(Console.ReadLine());

         for (int multiplier = 1; multiplier <= 10; multiplier++)
         {

            Console.WriteLine($"{multiple} X {multiplier} = {multiple * multiplier}");
         }
      }
   }
}
