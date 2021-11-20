using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Animals
{
   public interface IAnimal
   {

      public string Name { get; set; }
      public double Weight { get; set; }
      public int FoodEaten { get; set; }

      string ProduceSound();

      void Eat(IFood food);
   }
}
