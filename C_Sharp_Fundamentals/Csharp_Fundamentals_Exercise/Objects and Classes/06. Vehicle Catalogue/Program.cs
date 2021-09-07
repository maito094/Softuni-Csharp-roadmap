using System;
using System.Collections.Generic;
using System.Linq;


namespace _06.Vehicle_Catalogue
{
   class Program
   {
      static void Main(string[] args)
      {

         string[] input = Console.ReadLine().Split();

         Catalog theCatalog = new Catalog();
         while (input[0] != "End")
         {

            Car currentCar;
            Truck currentTruck;

            if (input[0] == "car")
            {
               currentCar = new Car(input[1], input[2], int.Parse(input[3]));

               theCatalog.Car.Add(currentCar);
            }
            else if (input[0] == "truck")
            {
               currentTruck = new Truck(input[1], input[2], int.Parse(input[3]));

               theCatalog.Truck.Add(currentTruck);
            }


            input = Console.ReadLine().Split();
         }


         int cntCars = theCatalog.Car.Count;
         int cntTrucks = theCatalog.Truck.Count;

         input = Console.ReadLine().Split();
         while (input[0] != "Close")
         {
            bool breakFlag = false;

            if (cntCars > 0 && theCatalog.Car.Find(s => s.Model == input[0]) != null)
            {
               Console.WriteLine(theCatalog.Car.Find(s => s.Model == input[0]).CarsString());
               breakFlag = true;
            }
            if (cntTrucks > 0 && breakFlag != true && theCatalog.Truck.Find(s => s.Model == input[0]) != null)
            {
               Console.WriteLine(theCatalog.Truck.Find(s => s.Model == input[0]).TrucksString());
            }
         

            input = Console.ReadLine().Split();
         }

         if (cntCars > 0) Console.WriteLine($"Cars have average horsepower of: {(theCatalog.Car.Sum(s => s.HorsePower) / (1.00 * cntCars)):f2}.");
         if (cntTrucks > 0) Console.WriteLine($"Trucks have average horsepower of: { (theCatalog.Truck.Sum(s => s.HorsePower) / (1.00 * cntTrucks)):f2}.");


      }
   }
   class Car
   {
      public string Model { get; set; }
      public string Color { get; set; }
      public int HorsePower { get; set; }
      public Car(string model, string color, int horsePower)
      {
         Model = model;
         Color = color;
         HorsePower = horsePower;
      }

      public Car()
      {
      }

      public string CarsString()
      {
         string result = ($"Type: Car\nModel: {Model}\nColor: {Color}\nHorsepower: {HorsePower}");

         return result;
      }
   }
   class Truck
   {
      public string Model { get; set; }
      public string Color { get; set; }
      public int HorsePower { get; set; }

      public Truck(string model, string color, int horsepower)
      {
         Model = model;
         Color = color;
         HorsePower = horsepower;
      }

      public Truck()
      {
      }
      public string TrucksString()
      {
         string result = ($"Type: Truck\nModel: {Model}\nColor: {Color}\nHorsepower: {HorsePower}");

         return result;
      }
   }
   class Catalog
   {
      public List<Car> Car = new List<Car>();
      public List<Truck> Truck = new List<Truck>();

      public Catalog()
      {
         Car = new List<Car>();
         Truck = new List<Truck>();
      }
   }
}


