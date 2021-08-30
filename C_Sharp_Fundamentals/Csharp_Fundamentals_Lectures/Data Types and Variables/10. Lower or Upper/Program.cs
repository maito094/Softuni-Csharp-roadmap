using System;

namespace _10._Lower_or_Upper
{
   class Program
   {
      static void Main(string[] args)
      {
         char symbol = char.Parse(Console.ReadLine());

         bool isUpperCase = (int)symbol >= 65 && (int)symbol <= 90;
         if (isUpperCase)
         {
            Console.WriteLine("upper-case");

         }
         else
         {

            Console.WriteLine("lower-case");
         }
      }
   }
}
