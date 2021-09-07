using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Vehicle_Catalogue
{
   class Program
   {
      static void Main(string[] args)
      {
         //List<int> random = Console.ReadLine()
         //                 .Split()
         //                 .Select(int.Parse)
         //                 .ToList();
         string[] input = Console.ReadLine().Split("/");

         Catalog theCatalog = new Catalog();
         while (input[0] != "end")
         {

            Car currentCar = new Car();
            Truck currentTruck = new Truck();

            if (input[0] == "Car")
            {
               currentCar = new Car(input[1], input[2], input[3]);

               theCatalog.Car.Add(currentCar);
            }
            else if (input[0] == "Truck")
            {
               currentTruck = new Truck(input[1], input[2], input[3]);

               theCatalog.Truck.Add(currentTruck);
            }


            input = Console.ReadLine().Split("/");
         }

         theCatalog.Car = theCatalog.Car.OrderBy(s => s.Brand).ToList();
         theCatalog.Truck = theCatalog.Truck.OrderBy(s => s.Brand).ToList();
         if (theCatalog.Car.Count > 0)
         {
            Console.WriteLine("Cars:");
            foreach (var car in theCatalog.Car)
            {
               Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
         }

         if (theCatalog.Truck.Count > 0)
         {
            Console.WriteLine("Trucks:");
            foreach (var truck in theCatalog.Truck)
            {
               Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
         }
      }
   }
   class Car
   {
      public string Brand { get; set; }
      public string Model { get; set; }
      public string HorsePower { get; set; }
      public Car(string brand, string model, string horsePower)
      {
         Brand = brand;
         Model = model;
         HorsePower = horsePower;
      }

      public Car()
      {
      }
   }
   class Truck
   {
      public string Brand { get; set; }
      public string Model { get; set; }
      public string Weight { get; set; }

      public Truck(string brand, string model, string weight)
      {
         Brand = brand;
         Model = model;
         Weight = weight;
      }

      public Truck()
      {
      }
   }
   class Catalog
   {
      public List<Car> Car = new List<Car>();
      public List<Truck> Truck = new List<Truck>();

      public Catalog()
      {
         //Car = new List<Car>();
         //Truck = new List<Truck>();
      }
   }
}
