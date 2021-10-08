using System;

namespace DefiningClasses

{
   public class StartUp
   {
      static void Main(string[] args)
      {
         Person person1 = new Person();
         person1.Name = "Metodi";
         person1.Age = 20;

         Person person2 = new Person
         {
            Name = "Metodi",
            Age = 20

         };

      }
   }
}
