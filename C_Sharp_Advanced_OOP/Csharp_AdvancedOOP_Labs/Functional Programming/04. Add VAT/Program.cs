using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Add_VAT
{
   class Program
   {
      static void Main(string[] args)
      {

         List<double> prices = Console.ReadLine()
                                      .Split(", ")
                                      .Select(double.Parse)
                                      .Select(x => x * 1.2)
                                      .ToList();

         foreach (var price in prices)
         {
            Console.WriteLine("{0:F2}",price);
         }
      }
   }
}
