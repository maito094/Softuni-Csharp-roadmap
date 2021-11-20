using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Food;

namespace Wild_Farm.Animals
{
   public class Dog : Mammal
   {
      public Dog(string name, double weight, string livingRegion)
         : base(name, weight, livingRegion)
      {
      }

      public override void Eat(IFood food)
      {
         if (!(food is Meat))
         {
            ThrowInvalidOperationExceptionForFood(this, food);
         }

         this.FoodEaten += food.Quantity;
         this.Weight += food.Quantity * 0.40;
      }

      public override string ProduceSound()
            => "Woof!";

      public override string ToString()
      {
         return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
      }
   }
}
