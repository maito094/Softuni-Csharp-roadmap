using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._2_Furniture
{
   class Program
   {
      static void Main(string[] args)
      {

         List<string> furnitures = new List<string>();

         string input = Console.ReadLine();
         string pattern = @">>(?<name>[A-z]+)<<(?<price>\d+|[0-9]+.[0-9]+)!(?<quantity>[0-9]+)\b";

         decimal totalSum = 0;

         while (!input.Contains("Purchase"))
         {
            bool isMatch = Regex.IsMatch(input, pattern);
            if (isMatch)
            {
               Match match = Regex.Match(input, pattern);

               string nameFurniture = match.Groups["name"].Value;
               decimal price = decimal.Parse(match.Groups["price"].Value);
               int quantity = int.Parse(match.Groups["quantity"].Value);
               totalSum += price * quantity;
               furnitures.Add(nameFurniture);
            }

            input = Console.ReadLine();
         }

         Console.WriteLine("Bought furniture:");
         foreach (var furniture in furnitures)
         {
            Console.WriteLine(furniture);

         }
         Console.WriteLine($"Total money spend: {totalSum:f2}");
      }
   }


}
