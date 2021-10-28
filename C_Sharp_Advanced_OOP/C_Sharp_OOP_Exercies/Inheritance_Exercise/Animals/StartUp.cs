using System;
using System.Collections.Generic;

namespace Animals
{
   public class StartUp
   {
      public static void Main(string[] args)
      {

         List<Animal> animals = new List<Animal>();

         while (true)
         {
            string input = Console.ReadLine();

            if (input == "Beast!")
            {
               break;
            }

            string[] animalInfo = Console.ReadLine().Split();

            string animalName = animalInfo[0];
            int animalAge = int.Parse(animalInfo[1]);
            string animalGender = animalInfo[2];

            //if (animalAge < 0)
            //{
            //   Console.WriteLine("Invalid input!");
            //   continue;
            //}


            if (input == "Cat")
            {
               Cat cat = new Cat(animalName, animalAge, animalGender);
               animals.Add(cat);
            }
            else if (input == "Tomcat")
            {
               Tomcat tomcat = new Tomcat(animalName, animalAge);
               animals.Add(tomcat);
            }
            else if (input == "Kitten")
            {
               Kitten kitten = new Kitten(animalName, animalAge);
               animals.Add(kitten);
            }
            else if (input == "Dog")
            {
               Dog dog = new Dog(animalName, animalAge, animalGender);
               animals.Add(dog);
            }
            else if (input == "Frog")
            {
               Frog frog = new Frog(animalName, animalAge, animalGender);
               animals.Add(frog);
            }


         }

         foreach (var animal in animals)
         {
            Console.WriteLine(animal.GetType().Name);
            Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
            Console.WriteLine(animal.ProduceSound());
         }

      }

   }
}
