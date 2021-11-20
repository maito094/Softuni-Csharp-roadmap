using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
   public class Citizen : IIdentifiable, IBirthable, INameable
   {

      public Citizen(string id, string name, int age, string birthDate)
      {
         Id = id;
         Name = name;
         Age = age;
         BirthDate = birthDate;
      }

      public string Id { get; set; }
      public string Name { get; set; }
      public int Age { get; set; }
      public string BirthDate { get; set; }
   }
}
