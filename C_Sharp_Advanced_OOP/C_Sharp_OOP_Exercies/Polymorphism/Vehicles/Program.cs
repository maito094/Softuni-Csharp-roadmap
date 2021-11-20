using System;

namespace Vehicles
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] carInfo = Console.ReadLine().Split();
         string[] truckInfo = Console.ReadLine().Split();

         double carFuelQuantity = double.Parse(carInfo[1]);
         double carFuelConsumption = double.Parse(carInfo[2]);

         double truckFuelQuantity = double.Parse(truckInfo[1]);
         double truckFuelConsumption = double.Parse(truckInfo[2]);

         IVehicle car = new Car(carFuelQuantity, carFuelConsumption);
         IVehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption);

         int n = int.Parse(Console.ReadLine());

         for (int i = 0; i < n; i++)
         {
            string[] inputInfo = Console.ReadLine().Split();
            string action = inputInfo[0];
            string vehicle = inputInfo[1];
            double value = double.Parse(inputInfo[2]);

            if (action == "Drive")
            {
               if (vehicle == "Car")
               {
                  if (car.CanDrive(value))
                  {

                     car.Drive(value);
                     Console.WriteLine($"Car travelled {value} km");
                  }
                  else
                  {
                     Console.WriteLine("Car needs refueling");
                  }
               }
               else if (vehicle == "Truck")
               {
                  if (truck.CanDrive(value))
                  {

                     truck.Drive(value);
                     Console.WriteLine($"Truck travelled {value} km");
                  }
                  else
                  {
                     Console.WriteLine("Truck needs refueling");
                  }
               }

            }
            else if (action == "Refuel")
            {
               if (vehicle == "Truck")
               {
                  truck.Refuel(value);
               }
               else if (vehicle == "Car")
               {
                  car.Refuel(value);
               }
            }

         }

         Console.WriteLine($"Car: {car.FuelQuantity:f2}");
         Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
      }
   }
}
