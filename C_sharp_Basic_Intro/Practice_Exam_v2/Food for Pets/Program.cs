using System;

namespace Food_for_Pets
{
   class Program
   {
      static void Main(string[] args)
      {
         int days = int.Parse(Console.ReadLine());
         double allFood = double.Parse(Console.ReadLine());
         double dogFood = 0;
         double catFood = 0;
         double dogFoodDaily = 0;
         double catFoodDaily = 0;
         double biscuit = 0;
         int n = 1;
         while (n <= days)
         {
            dogFoodDaily = double.Parse(Console.ReadLine());
            catFoodDaily = double.Parse(Console.ReadLine());
            dogFood += dogFoodDaily;
            catFood += catFoodDaily;
            if (n % 3 == 0)
            {
               biscuit += (dogFoodDaily + catFoodDaily) * 0.1;
            }
            n++;
         }

         Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuit)}gr.");
         Console.WriteLine($"{((dogFood + catFood) * 100.0 / allFood):f2}% of the food has been eaten.");
         Console.WriteLine($"{(dogFood * 100.0 / (dogFood + catFood)):f2}% eaten from the dog.");
         Console.WriteLine($"{(catFood * 100.0 / (dogFood + catFood)):f2}% eaten from the cat.");
      }
   }
}
