using System;
using System.Collections.Generic;

namespace _04._Orders
{
   class Program
   {
      static void Main(string[] args)
      {
         Dictionary<string, double[]> products = new Dictionary<string, double[]>();

         string input = Console.ReadLine();

         while (input != "buy")
         {
            string[] inputInfo = input.Split();
            string productName = inputInfo[0];
            double productPrice = double.Parse(inputInfo[1]);
            double productQuantity = double.Parse(inputInfo[2]);

            if (!products.ContainsKey(productName))
            {
               products.Add(productName, new double[2]);

            }
            double previousQty = products[productName][1];

            double[] priceQuantity = new double[] { productPrice, previousQty + productQuantity };
            products[productName] = priceQuantity;
            input = Console.ReadLine();
         }

         foreach (var item in products)
         {
            double totalPrice = item.Value[0] * item.Value[1];
            Console.WriteLine($"{ item.Key} -> {totalPrice:F2}");
         }
      }
   }
}
