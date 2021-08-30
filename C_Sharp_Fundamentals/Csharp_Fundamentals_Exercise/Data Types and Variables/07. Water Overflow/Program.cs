using System;

namespace _07._Water_Overflow
{
   class Program
   {
      static void Main(string[] args)
      {
         int capacity = 255;
         int n = int.Parse(Console.ReadLine());

         for (int i = 1; i <= n; i++)
         {
            int liters = int.Parse(Console.ReadLine());

            if (liters <= capacity)
            {
               capacity -= liters;
            }
            else
            {
               Console.WriteLine("Insufficient capacity!");
            }
         }
         Console.WriteLine(255 - capacity);
      }
   }
}
