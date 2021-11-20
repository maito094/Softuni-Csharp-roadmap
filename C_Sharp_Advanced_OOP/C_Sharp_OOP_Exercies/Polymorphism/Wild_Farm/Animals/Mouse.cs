﻿using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Food;

namespace Wild_Farm.Animals
{
   public class Mouse : Mammal
   {
      public Mouse(string name, double weight, string livingRegion)
         : base(name, weight, livingRegion)
      {
      }

      public override void Eat(IFood food)
      {
         if (food is Vegetable || food is Fruit)
         {
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 0.10;
         }
         else
         {
            ThrowInvalidOperationExceptionForFood(this, food);
         }

      }

      public override string ProduceSound()
            => "Squeak";

      public override string ToString()
      {
         return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
      }
   }
}
