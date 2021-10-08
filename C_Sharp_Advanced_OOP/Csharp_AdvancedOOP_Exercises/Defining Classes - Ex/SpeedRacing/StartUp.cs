using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
   {
      public static void Main(string[] args)
      {

         int numOfCars = int.Parse(Console.ReadLine());

         Dictionary<string, Car> cars = new Dictionary<string, Car>();

         for (int i = 0; i < numOfCars; i++)
         {
            string[] line = Console.ReadLine().Split();
            string model = line[0];
            double fuelAmount = double.Parse(line[1]);
            double fuelConsumptionFor1km = double.Parse(line[2]);

            Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
            cars.Add(model, car);
         }

         while (true)
         {
            string[] line = Console.ReadLine().Split();
            string cmd = line[0];

            if (cmd == "End")
            {
               break;
            }

            string carModel = line[1];
            double amountOfKm = double.Parse(line[2]);

            cars[carModel].CanCarDrive(amountOfKm);

         }

         foreach (var car in cars)
         {

            Console.WriteLine($"{car.Value.Model} {car.Value.FuelAmount:f2} {car.Value.TravelledDistance}");
         }
      }
   }
}
