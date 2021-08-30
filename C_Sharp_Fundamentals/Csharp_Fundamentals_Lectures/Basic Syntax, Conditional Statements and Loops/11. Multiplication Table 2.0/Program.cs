using System;

namespace _11._Multiplication_Table_2._0
{
   class Program
   {
      static void Main(string[] args)
      {
         int multiple = int.Parse(Console.ReadLine());
         int multiplier = int.Parse(Console.ReadLine());

         if (multiplier > 10)
         {
            Console.WriteLine($"{multiple} X {multiplier} = {multiple * multiplier}");
            return;
         }
         for (; multiplier <= 10; multiplier++)
         {

            Console.WriteLine($"{multiple} X {multiplier} = {multiple * multiplier}");
         }

      }
   }
}
