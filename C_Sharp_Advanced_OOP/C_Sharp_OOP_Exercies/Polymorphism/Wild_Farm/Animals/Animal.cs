﻿using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Food;

namespace Wild_Farm.Animals
{
   public abstract class Animal : IAnimal
   {
      public Animal(string name, double weight)
      {
         Name = name;
         Weight = weight;
        
      }

      public string Name { get; set; }
      public double Weight { get; set; }
      public int FoodEaten { get; set; }

      public abstract void Eat(IFood food);


      public abstract string ProduceSound();

      protected void ThrowInvalidOperationExceptionForFood(IAnimal animal,IFood food)
      {
         throw new InvalidOperationException($"{animal.GetType().Name} does not eat {food.GetType().Name}!");

      }

   }
}
