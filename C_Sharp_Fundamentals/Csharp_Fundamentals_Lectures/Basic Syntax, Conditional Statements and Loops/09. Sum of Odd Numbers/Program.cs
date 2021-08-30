using System;

namespace _09._Sum_of_Odd_Numbers
{
   class Program
   {
      static void Main(string[] args)
      {
         int numOdds = int.Parse(Console.ReadLine());
         int sumOdds = 0;
         for (int i = 1; i < numOdds * 2; i++)
         {
            if (i % 2 != 0)
            {
               sumOdds += i;
               Console.WriteLine($"{i}");
            }

         }
         Console.WriteLine($"Sum: {sumOdds}");
      }
   }
}
