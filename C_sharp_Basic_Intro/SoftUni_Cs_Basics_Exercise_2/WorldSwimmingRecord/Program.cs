using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecordSeconds = double.Parse(Console.ReadLine());
            double distanceMeteres = double.Parse(Console.ReadLine());
            double timeMeterPerSeconds = double.Parse(Console.ReadLine());
         //   double waterResistanceMeterPerSeconds = 15 / 12.5; it is not usable, because in the Conditions the Times Swimer is restricted by the resistance of water per 15 meters must be Floored.

            double timePerSwimmingDistance = distanceMeteres * timeMeterPerSeconds + Math.Floor(distanceMeteres / 15) * 12.5 ;
            if (timePerSwimmingDistance >= worldRecordSeconds)
            {
                double timeDifferanceOfWorldRecord = timePerSwimmingDistance - worldRecordSeconds;

                Console.WriteLine($"No, he failed! He was {timeDifferanceOfWorldRecord:0.00} seconds slower.");
            }
            else if (timePerSwimmingDistance < worldRecordSeconds)
            {

                Console.WriteLine($"Yes, he succeeded! The new world record is {Math.Abs(timePerSwimmingDistance):0.00} seconds.");
            }
           
        }
    }
}
