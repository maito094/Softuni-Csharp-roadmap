using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
   class Program
   {
      static void Main(string[] args)
      {

         List<Furniture> furnitures = new List<Furniture>();

         string input = Console.ReadLine();
         string pattern = @">>(?<name>.+)<<(?<price>\d+|[0-9]+.[0-9]+)!(?<quantity>\d+)\b";

         decimal totalSum = 0;
         while (!input.Contains("Purchase"))
         {
            bool isMatch = Regex.IsMatch(input, pattern);
            if (isMatch)
            {
               Match match = Regex.Match(input, pattern);

               string nameFurniture = match.Groups["name"].Value;
               string price = match.Groups["price"].Value;
               string quantity = match.Groups["quantity"].Value;
               furnitures.Add(new Furniture(nameFurniture, decimal.Parse(price), int.Parse(quantity)));
            }

            input = Console.ReadLine();
         }

         Console.WriteLine("Bought furniture:");
         foreach (var furniture in furnitures)
         {
            Console.WriteLine(furniture.FurnitureName);
            totalSum += furniture.Price;
         }
         Console.WriteLine($"Total money spend: {totalSum:f2}");
      }
   }

   class Furniture
   {
      public string FurnitureName { get; set; }
      public decimal Price { get; set; }

      public Furniture(string name, decimal price, int quantity)
      {
         FurnitureName = name;
         Price = price * quantity;
      }
   }
}
