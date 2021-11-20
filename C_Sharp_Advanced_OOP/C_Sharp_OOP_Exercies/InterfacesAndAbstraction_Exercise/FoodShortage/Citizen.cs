using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
   public class Citizen : IPerson, IBirthable, IIdentifiable, IBuyer
   {
      public Citizen(string name, int age, string id, string birthDate)
      {
         Name = name;
         Age = age;
         Id = id;
         BirthDate = birthDate;
      }

      public string Name { get; set; }
      public int Age { get; set; }
      public string Id { get; set; }
      public string BirthDate { get; set; }
      public int Food { get; set; } = 0;

      public void BuyFood()
      {
         this.Food += 10;
      }
   }
}
