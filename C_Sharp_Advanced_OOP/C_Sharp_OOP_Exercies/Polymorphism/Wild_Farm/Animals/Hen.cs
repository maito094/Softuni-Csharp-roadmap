﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Animals
{
   public class Hen : Bird
   {
      public Hen(string name, double weight, double wingSize)
         : base(name, weight, wingSize)
      {
      }

      public override void Eat(IFood food)
      {
         this.FoodEaten += food.Quantity;
         this.Weight += food.Quantity * 0.35;

      }

      public override string ProduceSound()
            => "Cluck";
   }
}
