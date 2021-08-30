using System;

namespace _08._Beer_Kegs
{
   class Program
   {
      static void Main(string[] args)
      {

         string biggestKeg = string.Empty;
         double largestVolume = 0;

         int n = int.Parse(Console.ReadLine());

         for (int i = 1; i <= n; i++)
         {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volume = Math.PI * height * radius * radius;

            if (volume > largestVolume)
            {
               biggestKeg = model;
               largestVolume = volume;
            }
            else
            {
               continue;
            }
         }
         Console.WriteLine(biggestKeg);
      }
   }
}
