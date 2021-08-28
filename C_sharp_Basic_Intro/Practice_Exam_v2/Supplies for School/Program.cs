using System;

namespace Supplies_for_School
{
   class Program
   {
      static void Main(string[] args)
      {
         //Package pens 5.80lv
         //Package markers 7.20lv
         //Cleaner 1.20lv/liter

         int numPacksOfPens = int.Parse(Console.ReadLine());
         int numPacksOfMarkers = int.Parse(Console.ReadLine());
         double litresCleaner = double.Parse(Console.ReadLine());
         int percentDiscount = int.Parse(Console.ReadLine());

         double result = 0;

         result = numPacksOfPens * 5.80 + numPacksOfMarkers * 7.20 + litresCleaner * 1.20;
         result = result * (1 - percentDiscount * 1.0 / 100);
         Console.WriteLine($"{result:f3}");
      }
   }
}
