namespace AnimalFarm
{
   using System;
   using System.Collections.Generic;
   using System.Text;
   using AnimalFarm.Models;
   class Program
   {
      static void Main(string[] args)
      {
         //1st Problem
         //double length = double.Parse(Console.ReadLine());
         //double width = double.Parse(Console.ReadLine());
         //double height = double.Parse(Console.ReadLine());

         //try
         //{
         //   Box box = new Box(length, width, height);
         //   Console.WriteLine($"Surface Area - {box.SurfaceArea():F2}");
         //   Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F2}");
         //   Console.WriteLine($"Volume - {box.Volume():F2}");
         //}
         //catch (Exception ex)
         //{

         //   Console.WriteLine(ex.Message);
         //}


         //2nd Problem
         //string name = Console.ReadLine();
         //int age = int.Parse(Console.ReadLine());

         //try
         //{
         //   Chicken chicken = new Chicken(name, age);
         //   Console.WriteLine(
         //       "Chicken {0} (age {1}) can produce {2} eggs per day.",
         //       chicken.Name,
         //       chicken.Age,
         //       chicken.ProductPerDay);


         //}
         //catch (Exception ex)
         //{

         //   Console.WriteLine(ex.Message);
         //}


         //3rd Problem
         //try
         //{
         //   Dictionary<string, Person> peopleDictionary = new Dictionary<string, Person>();

         //   string[] peopleInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

         //   foreach (var person in peopleInput)
         //   {
         //      string personName = person.Split("=")[0];
         //      decimal personMoney = decimal.Parse(person.Split("=")[1]);
         //      peopleDictionary.Add(personName, new Person(personName, personMoney));

         //   }

         //   Dictionary<string, Product> productsDictionary = new Dictionary<string, Product>();

         //   string[] productInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

         //   foreach (var product in productInput)
         //   {
         //      string productName = product.Split("=")[0];
         //      decimal productMoney = decimal.Parse(product.Split("=")[1]);
         //      productsDictionary.Add(productName, new Product(productName, productMoney));

         //   }


         //   while (true)
         //   {
         //      var inputInfo = Console.ReadLine().Split();

         //      string personBuyer = inputInfo[0];
         //      if (personBuyer == "END")
         //      {
         //         break;
         //      }
         //      string productBought = inputInfo[1];

         //      peopleDictionary[personBuyer].BuyProduct(productsDictionary[productBought]);

         //   }



         //   foreach (var person in peopleDictionary.Values)
         //   {
         //      StringBuilder sb = new StringBuilder();
         //      sb.Append($"{person.Name} -");

         //      foreach (var product in person.BagOfProducts)
         //      {

         //         sb.Append($" {product.Name},");

         //      }
         //      if (person.BagOfProducts.Count == 0)
         //      {
         //         sb.Append(" Nothing bought");
         //      }

         //      Console.WriteLine(sb.ToString().TrimEnd(','));

         //   }
         //}
         //catch (Exception ex)
         //{

         //   Console.WriteLine(ex.Message);
         //   return;
         //}

         try
         {
            string[] pizzaInfo = Console.ReadLine().Split();
            string[] doughInfo = Console.ReadLine().Split();


            string pizzaName = pizzaInfo[1];
            string doughFlourType = doughInfo[1];
            string bakingTechnique = doughInfo[2];
            double doughWeight = double.Parse(doughInfo[3]);

            Dough dough = new Dough(doughFlourType, bakingTechnique, doughWeight);
            Pizza pizza = new Pizza(pizzaName, dough);

            while (true)
            {
               string[] toppingInfo = Console.ReadLine().Split();

               if (toppingInfo[0] == "END")
               {
                  break;
               }

               string toppingType = toppingInfo[1];
               double toppingWeight = double.Parse(toppingInfo[2]);

               Topping topping = new Topping(toppingType, toppingWeight);
               pizza.AddTopping(topping);


            }

            Console.WriteLine($"{pizza.Name} - {pizza.CalculateTotalCalories():f2} Calories.");

         }
         catch (Exception ex)
         {

            Console.WriteLine(ex.Message);
         }

      }
   }
}
