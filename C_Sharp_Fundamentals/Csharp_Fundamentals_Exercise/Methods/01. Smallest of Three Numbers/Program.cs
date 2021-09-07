using System;

namespace _01._Smallest_of_Three_Numbers
{
   class Program
   {
      static void Main(string[] args)
      {
         int a = int.Parse(Console.ReadLine());
         int b = int.Parse(Console.ReadLine());
         int c = int.Parse(Console.ReadLine());

         Console.WriteLine(GetMinNumber(a, b, c));
      }
      static int GetMinNumber(int a, int b, int c)
      {
         int minNumber = int.MaxValue;

         if (a < b && a < c)
         {
            return minNumber = a;
         }
         else if (b < a && b < c)
         {
            return minNumber = b;
         }
         return minNumber = c;
      }
   }
}
