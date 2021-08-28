using System;

namespace Workout
{
   class Program
   {
      static void Main(string[] args)
      {
         double thousandKm = 1000;
         int numDays = int.Parse(Console.ReadLine());
         double mKm = double.Parse(Console.ReadLine()); //first day ran
         thousandKm -= mKm;
         int n = 1;
         int percents = 0;
         while (n <= numDays)
         {

            percents = int.Parse(Console.ReadLine());

            mKm = (mKm + mKm * percents / 100);
            thousandKm -= mKm;

            n++;
         }
         if (thousandKm >= 0)
         {
            Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(thousandKm)} more kilometers");

         }
         else
         {
            Console.WriteLine($"You've done a great job running {Math.Ceiling(Math.Abs(thousandKm))} more kilometers!");

         }
      }
   }
}
