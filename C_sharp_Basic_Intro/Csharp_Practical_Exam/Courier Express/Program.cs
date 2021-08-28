using System;

namespace Courier_Express
{
   class Program
   {
      static void Main(string[] args)
      {
         double weightParcel = double.Parse(Console.ReadLine());
         string typeService = Console.ReadLine();
         int distance = int.Parse(Console.ReadLine());

         double pricePerKm = 0;
         double priceService = 0;

         double express = 0;

         if (weightParcel < 1)
         {
            pricePerKm = 3 * 1.0 / 100; //3 stotinki
            if (typeService == "express")
               express = 0.8 * pricePerKm * weightParcel;
         }
         else if (weightParcel >= 1 && weightParcel < 10)
         {
            pricePerKm = 5 * 1.0 / 100;
            if (typeService == "express")
               express = 0.4 * pricePerKm * weightParcel;
         }
         else if (weightParcel >= 10 && weightParcel < 40)
         {
            pricePerKm = 10 * 1.0 / 100;
            if (typeService == "express")
               express = 0.05 * pricePerKm * weightParcel;
         }
         else if (weightParcel >= 40 && weightParcel < 90)
         {
            pricePerKm = 15 * 1.0 / 100;
            if (typeService == "express")
               express = 0.02 * pricePerKm * weightParcel;
         }
         else if (weightParcel >= 90 && weightParcel < 150)
         {
            pricePerKm = 20 * 1.0 / 100;
            if (typeService == "express")
               express = 0.01 * pricePerKm * weightParcel;
         }


         priceService = (pricePerKm + express) * distance;
         Console.WriteLine($"The delivery of your shipment with weight of {weightParcel:F3} kg. would cost {priceService:f2} lv.");
      }
   }
}
