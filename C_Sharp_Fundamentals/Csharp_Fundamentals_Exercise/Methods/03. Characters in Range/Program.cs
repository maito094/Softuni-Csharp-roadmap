using System;

namespace _03._Characters_in_Range
{
   class Program
   {
      static void Main(string[] args)
      {
         char first = char.Parse(Console.ReadLine());
         char second = char.Parse(Console.ReadLine());

         printCharsBetween(first, second);
      }

      static void printCharsBetween(char start, char end)
      {
         int i = 0;
         if ((int)start > (int)end)
         {
            i = end + 1;
            end = start;
         }
         else
         {
            i = start + 1;
         }
         for (i = i; i < end; i++)
         {
            Console.Write(string.Concat((char)i, " "));
         }
      }
   }
}
