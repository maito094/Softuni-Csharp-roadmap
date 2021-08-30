using System;

namespace _02._Division
{
   class Program
   {
      static void Main(string[] args)
      {
         int num = int.Parse(Console.ReadLine());

         if (num % 10 == 0)
         {
            num = 10;
         }
         else if (num % 7 == 0)
         {
            num = 7;
         }
         else if (num % 6 == 0)
         {
            num = 6;
         }
         else if (num % 3 == 0)
         {
            num = 3;
         }
         else if (num % 2 == 0)
         {
            num = 2;
         }
         else
         {
            num = 0;
         }

         if (num > 0)
         {
            Console.WriteLine($"The number is divisible by {num}");

         }
         else
         {
            Console.WriteLine($"Not divisible");
         }
      }
   }
}
