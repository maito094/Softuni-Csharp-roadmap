using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Food;

namespace Wild_Farm.Animals
{
   public class Tiger : Feline
   {
      public Tiger(string name, double weight, string livingRegion, string breed)
         : base(name, weight, livingRegion, breed)
      {
      }

      public override void Eat(IFood food)
      {
         if (!(food is Meat))
         {
            ThrowInvalidOperationExceptionForFood(this, food);
         }

         this.FoodEaten += food.Quantity;
         this.Weight += food.Quantity * 1.00;
      }

      public override string ProduceSound()
         => "ROAR!!!";
   }
}
