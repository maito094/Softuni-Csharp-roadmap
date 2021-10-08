using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class Engine
   {
      public Engine(string model, int power)
      {
         Model = model;
         Power = power;

      }
      public Engine(string model, int power, int displacement)
      {
         Model = model;
         Power = power;
         Displacement = displacement;
      }

      public Engine(string model, int power, string efficiency)
      {
         Model = model;
         Power = power;
         Efficiency = efficiency;
      }
      public Engine(string model, int power, int displacement, string efficiency)
      {
         Model = model;
         Power = power;
         Displacement = displacement;
         Efficiency = efficiency;
      }

      public string Model { get; set; }
      public int Power { get; set; }
      public int Displacement { get; set; }
      public string Efficiency { get; set; }

      public override string ToString()
      {
         StringBuilder engine = new StringBuilder();
         engine.AppendLine($"  {Model}:");
         engine.AppendLine($"    Power: {Power}");
         //optional parameters
         engine.AppendLine($"    Displacement: {StartUp.isNullorZero(Displacement)}");
         engine.Append($"    Efficiency: {StartUp.isNullorZero(Efficiency)}");

         return engine.ToString();
      }


   }
}
