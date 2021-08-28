using System;

namespace Multiplication_Table
{
   class Program
   {
      static void Main(string[] args)
      {
         for (int multiple = 1; multiple <= 10; multiple++)
         {
            for (int multiplier = 1; multiplier <= 10; multiplier++)
            {
               int result = multiple * multiplier;
               Console.WriteLine($"{ multiple} * { multiplier} = { result}");
            }

         }
      }
   }
}
