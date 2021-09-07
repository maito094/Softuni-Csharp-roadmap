using System;
using System.Collections.Generic;
using System.Linq;


namespace _06.Vehicle_Catalogue_V2
{
   class Program
   {
      static void Main(string[] args)
      {
         string input = Console.ReadLine();

         List<Vehicle> catalogue = new List<Vehicle>();

         while (input != "End")
         {
            string[] vehicleData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Vehicle currentVehicle = new Vehicle(vehicleData[0], vehicleData[1], vehicleData[2], double.Parse(vehicleData[3]));

            catalogue.Add(currentVehicle);

            input = Console.ReadLine();
         }

         string typeInput = Console.ReadLine();
         while (typeInput != "Close the Catalogue")
         {
            int index = catalogue.FindIndex(s => s.Model == typeInput);
            Console.WriteLine(catalogue[index]);
            // Console.WriteLine(catalogue.Find(s => s.Model == typeInput).ToString());
            typeInput = Console.ReadLine();
         }



         double avgCarHorsepower = catalogue.FindAll(p => p.TypeOfVehicle == "car").Select(s => s.HorsePower).Sum() / (double)catalogue.Count(s => s.TypeOfVehicle == "car");
         double avgTruckHorsepower = catalogue.FindAll(p => p.TypeOfVehicle == "truck").Select(s => s.HorsePower).Sum() / (double)catalogue.Count(s => s.TypeOfVehicle == "truck");
         Console.WriteLine(double.IsNaN(avgCarHorsepower) ? "Cars have average horsepower of: 0.00" : $"Cars have average horsepower of: {avgCarHorsepower:f2}.");
         Console.WriteLine(double.IsNaN(avgTruckHorsepower) ? "Trucks have average horsepower of: 0.00" : $"Trucks have average horsepower of: { avgTruckHorsepower:f2}.");


      }
   }

   class Vehicle
   {
      public string TypeOfVehicle { get; set; }
      public string Model { get; set; }
      public string Color { get; set; }
      public double HorsePower { get; set; }

      public Vehicle(string typeOfVehicle, string model, string color, double horsepower)
      {
         TypeOfVehicle = typeOfVehicle;
         Model = model;
         Color = color;
         HorsePower = horsepower;
      }


      public override string ToString()
      {
         return $"Type: {(TypeOfVehicle == "car" ? "Car" : "Truck")}{Environment.NewLine}" + $"Model: {Model}{Environment.NewLine}" + $"Color: {Color}{Environment.NewLine}" + $"Horsepower: {HorsePower}";

      }

   }
}


