using System;

namespace _06._Tri_bit_Switch
{
   class Program
   {
      static void Main(string[] args)
      {
         int number = int.Parse(Console.ReadLine());
         int p = int.Parse(Console.ReadLine());

         int maskp = 7 << p;

         number = number ^ maskp;

         Console.WriteLine(number);

      }
   }
}
