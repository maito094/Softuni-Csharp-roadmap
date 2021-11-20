using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
   public abstract class Vehicle : IVehicle
   {
      private double fuelQuantity;
      private double fuelConsumption;

      protected Vehicle(double fuelQuantity, double fuelConsumption)
      {
         this.FuelQuantity = fuelQuantity;
         this.FuelConsumption = fuelConsumption;
      }

      public double FuelQuantity
      {
         get => fuelQuantity;
         set => fuelQuantity = value;
      }
      public virtual double FuelConsumption
      {
         get => fuelConsumption;
         set => fuelConsumption = value;
      }

      public bool CanDrive(double km)
         => this.FuelQuantity - (km * this.FuelConsumption) >= 0;


      public void Drive(double km)
      {
         if (!CanDrive(km))
         {
            return;
         }
         this.FuelQuantity -= km * this.FuelConsumption;
      }

      public virtual void Refuel(double liters)
      {
         this.FuelQuantity += liters;
      }

   }
}
