using System;
using System.Collections.Generic;

namespace _03._Product_Shop
{
   class Program
   {
      static void Main(string[] args)
      {

         SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

         while (true)
         {

            var lines = Console.ReadLine().Split(", ");

            if (lines[0] == "Revision")
            {
               break;
            }
            string shop = lines[0];
            string product = lines[1];
            double price = double.Parse(lines[2]);

            if (!shops.ContainsKey(shop))
            {
               shops.Add(shop, new Dictionary<string, double>());
               shops[shop].Add(product, price);
            }
            else
            {
               shops[shop].Add(product, price);
            }

         }

         foreach (var shop in shops)
         {
            Console.WriteLine(shop.Key + "->");

            foreach (var product in shop.Value)
            {
               Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
            }
         }

      }
   }
}
