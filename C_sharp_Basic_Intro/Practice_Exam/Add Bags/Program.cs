using System;

namespace Add_Bags
{
   class Program
   {
      static void Main(string[] args)
      {
         double priceOver20KgBag = double.Parse(Console.ReadLine());
         double weightBag = double.Parse(Console.ReadLine());
         int daysUntilTravel = int.Parse(Console.ReadLine());
         int numBags = int.Parse(Console.ReadLine());

         if (weightBag < 10)
         {
            priceOver20KgBag = priceOver20KgBag * 0.2;
         }
         else if (weightBag >= 10 && weightBag <= 20)
         {
            priceOver20KgBag = priceOver20KgBag * 0.5;
         }

         if (daysUntilTravel > 30)
         {
            priceOver20KgBag += priceOver20KgBag * 0.1;
         }
         else if (daysUntilTravel >= 7 && daysUntilTravel <= 30)
         {
            priceOver20KgBag += priceOver20KgBag * 0.15;

         }
         else if (daysUntilTravel < 7)
         {
            priceOver20KgBag += priceOver20KgBag * 0.4;

         }

         double taxBags = numBags * priceOver20KgBag;
         Console.WriteLine($" The total price of bags is: {taxBags:f2} lv. ");
      }
   }
}
