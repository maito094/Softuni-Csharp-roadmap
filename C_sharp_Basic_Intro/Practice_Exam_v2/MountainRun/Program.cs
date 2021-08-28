using System;

namespace MountainRun
{
   class Program
   {
      static void Main(string[] args)
      {
         double recordTime = double.Parse(Console.ReadLine());
         double distance = double.Parse(Console.ReadLine());
         double SecondsPerMeter = double.Parse(Console.ReadLine());
         //Every 50m adds 30 seconds to George's time using Math.Floor everytime on the result
         double resultTime = 0;

         resultTime = Math.Floor(distance * 1.0 / 50) * 30 + distance * SecondsPerMeter;
         if (recordTime > resultTime)
         {
            Console.WriteLine($" Yes! The new record is {resultTime:f2} seconds.");

         }
         else
         {

            Console.WriteLine($"No! He was { (resultTime - recordTime):f2} seconds slower.");
         }
      }
   }
}
