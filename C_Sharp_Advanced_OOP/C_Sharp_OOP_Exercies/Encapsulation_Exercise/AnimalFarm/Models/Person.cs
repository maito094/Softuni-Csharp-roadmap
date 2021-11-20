using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Models
{
   public class Person
   {

      private string name;
      private decimal money;

      private List<Product> bagOfProducts;
      public IReadOnlyCollection<Product> BagOfProducts
            => bagOfProducts;

      public Person(string name, decimal money)
      {
         Name = name;
         Money = money;

         bagOfProducts = new List<Product>();
      }

      public string Name
      {
         get { return name; }
         private set
         {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
               throw new ArgumentException("Name cannot be empty");
            }
            name = value;
         }
      }


      public decimal Money
      {
         get { return money; }
         private set
         {
            if (value < 0)
            {
               throw new ArgumentException("Money cannot be negative");
            }
            money = value;
         }
      }


      public void BuyProduct(Product product)
      {
         if (Money - product.Cost >= 0)
         {

            bagOfProducts.Add(product);
            Money -= product.Cost;
            Console.WriteLine($"{Name} bought {product.Name}");
         }
         else
         {

            Console.WriteLine($"{Name} can't afford {product.Name}");
         }

      }


   }
}
