using System;

namespace Care_of_Puppy
{
   class Program
   {
      static void Main(string[] args)
      {
         int dailyFoodKg = int.Parse(Console.ReadLine());//kg
         string cmd = Console.ReadLine();
         int foodEatenDaily = 0;//gr
         while (cmd != "Adopted") //&& dailyFoodKg * 1000 >= foodEatenDaily)
         {
            foodEatenDaily += int.Parse(cmd);
            cmd = Console.ReadLine();

         }

         if (foodEatenDaily <= dailyFoodKg * 1000)
         {

            Console.WriteLine($"Food is enough! Leftovers: {dailyFoodKg * 1000 - foodEatenDaily} grams.");
         }
         else
         {
            Console.WriteLine($"Food is not enough. You need {Math.Abs(dailyFoodKg * 1000 - foodEatenDaily)} grams more.");

         }
      }
   }
}
