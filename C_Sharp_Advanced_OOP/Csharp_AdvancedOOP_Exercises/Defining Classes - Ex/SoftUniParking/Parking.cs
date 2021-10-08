using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
   public class Parking
   {
      public Parking(int _capacity)
      {
         this.cars = new Dictionary<string, Car>();
         this.capacity = _capacity;
      }

      private Dictionary<string, Car> cars;
      private int capacity;

      public int Count
      {
         get
         {
            return cars.Count;
         }
      }

      public string AddCar(Car car)
      {
         string resultReturn = string.Empty;
         if (cars.ContainsKey(car.RegistrationNumber))
         {
            resultReturn = "Car with that registration number, already exists!";
         }
         else if (cars.Count >= capacity)
         {
            resultReturn = "Parking is full!";
         }
         else
         {
            cars.Add(car.RegistrationNumber, car);
            resultReturn = $"Successfully added new car {car.Make} {car.RegistrationNumber}";
         }
         return resultReturn;
      }

      public string RemoveCar(string registrationNumber)
      {
         string resultReturn = string.Empty;
         if (!cars.ContainsKey(registrationNumber))
         {
            resultReturn = "Car with that registration number, doesn't exist!";
         }
         else
         {
            cars.Remove(registrationNumber);
            resultReturn = $"Successfully removed {registrationNumber}";
         }
         return resultReturn;
      }

      public Car GetCar(string registrationNumber)
      {
         return cars[registrationNumber];
      }

      public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
      {
         for (int i = 0; i < registrationNumbers.Count; i++)
         {
            if (cars.ContainsKey(registrationNumbers[i]))
            {
               cars.Remove(registrationNumbers[i]);
            }
         }

      }

   }
}
