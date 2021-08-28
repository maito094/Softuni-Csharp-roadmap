using System;

namespace Energy_Booster
{
   class Program
   {
      static void Main(string[] args)
      {
         string fruit = Console.ReadLine();//"Watermelon", "Mango", "Pineapple" или "Raspberry"
         string size = Console.ReadLine(); //"small"-2 or "big"-5
         int numPacks = int.Parse(Console.ReadLine());

         double priceOfOrder = 0;
         double priceResult = 0;
         int percentDiscount = 0;
         switch (fruit)
         {
         case "Watermelon":
            if (size == "small")
            {
               priceOfOrder = 56 * 2;
            }
            else
            {
               priceOfOrder = 28.70 * 5;
            }
            break;
         case "Mango":
            if (size == "small")
            {
               priceOfOrder = 36.66 * 2;
            }
            else
            {
               priceOfOrder = 19.60 * 5;
            }
            break;
         case "Pineapple":
            if (size == "small")
            {
               priceOfOrder = 42.10 * 2;
            }
            else
            {
               priceOfOrder = 24.80 * 5;
            }
            break;
         case "Raspberry":
            if (size == "small")
            {
               priceOfOrder = 20 * 2;
            }
            else
            {
               priceOfOrder = 15.20 * 5;
            }
            break;
         default:
            break;
         }

         priceResult = priceOfOrder * numPacks;
         if (priceResult >= 400 && priceResult <= 1000)
         {
            percentDiscount = 15;
            priceResult = priceResult * (1 - percentDiscount * 1.0 / 100);
         }
         else if (priceResult > 1000)
         {
            percentDiscount = 50;
            priceResult = priceResult * (1 - percentDiscount * 1.0 / 100);
         }

         Console.WriteLine($"{priceResult:f2} lv.");
      }
   }
}
