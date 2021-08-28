using System;

namespace Cat_Walking
{
   class Program
   {
      static void Main(string[] args)
      {
         int minWalk = int.Parse(Console.ReadLine()); // 1min == 5 calories burned.
         int walksPerDay = int.Parse(Console.ReadLine());
         int calorieIntakeDaily = int.Parse(Console.ReadLine());


         if (calorieIntakeDaily * 1.0 / 2 <= minWalk * walksPerDay * 5.0)
         {
            Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {minWalk * walksPerDay * 5.0}.");

         }
         else
         {

            Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {minWalk * walksPerDay * 5.0}.");
         }
      }
   }
}
