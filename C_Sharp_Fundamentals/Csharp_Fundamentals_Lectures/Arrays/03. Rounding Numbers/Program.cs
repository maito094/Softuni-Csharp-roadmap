using System;

namespace _03._Rounding_Numbers
{
   class Program
   {
      static void Main(string[] args)
      {

         string[] readLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
         int[] roundedNums = new int[readLine.Length];

         for (int i = 0; i < readLine.Length; i++)
         {
            roundedNums[i] = (int)Math.Round(double.Parse(readLine[i]), MidpointRounding.AwayFromZero);
            Console.WriteLine($" {readLine[i]} => {roundedNums[i]}");
         }
      }
   }
}
