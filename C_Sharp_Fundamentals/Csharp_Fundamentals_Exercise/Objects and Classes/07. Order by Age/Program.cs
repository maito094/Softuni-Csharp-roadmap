using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Order_by_Age
{
   class Program
   {
      static void Main(string[] args)
      {

         string[] input = Console.ReadLine().Split();
         List<Person> listPeople = new List<Person>();
         while (input[0] != "End")
         {
            Person currentPerson = new Person(input[0], input[1], int.Parse(input[2]));

            listPeople.Add(currentPerson);

            input = Console.ReadLine().Split();
         }

         listPeople = listPeople.OrderBy(o => o.Age).ToList();

         foreach (var person in listPeople)
         {
            Console.WriteLine(person.ToString());
         }

      }
   }
   class Person
   {
      public string Name { get; set; }
      public string ID { get; set; }
      public int Age { get; set; }

      public Person(string name, string id, int age)
      {
         Name = name;
         ID = id;
         Age = age;
      }

      public override string ToString()
      {
         return $"{Name} with ID: {ID} is {Age} years old.";
      }
   }
}
