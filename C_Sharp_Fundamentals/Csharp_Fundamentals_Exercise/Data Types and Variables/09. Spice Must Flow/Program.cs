using System;

namespace _09._Spice_Must_Flow
{
   class Program
   {
      static void Main(string[] args)
      {
         int startingYield = int.Parse(Console.ReadLine());
         int totalSum = 0;
         int daysElapsed = 0;
         int todaysYield = startingYield;

         while (todaysYield >= 100)
         {

            daysElapsed++;
            totalSum += todaysYield - 26;
            todaysYield -= 10;
         }

         if (daysElapsed > 0)
         {
            totalSum -= 26;
         }

         Console.WriteLine(daysElapsed);
         Console.WriteLine(totalSum);
      }
   }
}
