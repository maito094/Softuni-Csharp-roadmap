using System;

namespace Aluminum_Joinery
{
   class Program
   {
      static void Main(string[] args)
      {
         int numFrame = int.Parse(Console.ReadLine());
         if (numFrame <= 10)
         {
            Console.WriteLine("Invalid order");
            return;
         }
         string typeFrame = Console.ReadLine(); //"90X130";"100X150";"130X180";"200X300"
         string delivery = Console.ReadLine();

         double pricePerFrame = 0;
         double discount = 1;
         double price = 0;


         switch (typeFrame)
         {
         case "90X130":
            pricePerFrame = 110;
            if (numFrame > 30 && numFrame <= 60)
            {

               discount = 0.95;
            }
            else if (numFrame > 60)
            {
               discount = 0.92;
            }
            break;
         case "100X150":
            pricePerFrame = 140;
            if (numFrame > 40 && numFrame <= 80)
            {

               discount = 0.94;
            }
            else if (numFrame > 80)
            {
               discount = 0.90;
            }
            break;
         case "130X180":
            pricePerFrame = 190;
            if (numFrame > 20 && numFrame <= 50)
            {

               discount = 0.93;
            }
            else if (numFrame > 50)
            {
               discount = 0.88;
            }
            break;
         case "200X300":
            pricePerFrame = 250;
            if (numFrame > 25 && numFrame <= 50)
            {

               discount = 0.91;
            }
            else if (numFrame > 50)
            {
               discount = 0.86;
            }
            break;

         }

         if (numFrame > 99)
         {
            if (delivery == "With delivery")
            {
               price = (60 + numFrame * pricePerFrame * discount) * 0.96;
            }
            else
            {
               price = (numFrame * pricePerFrame * discount) * 0.96;
            }
         }
         else
         {
            if (delivery == "With delivery")
            {
               price = (60 + numFrame * pricePerFrame * discount);

            }
            else
            {
               price = (numFrame * pricePerFrame * discount);

            }

         }

         Console.WriteLine($"{price:F2} BGN");
      }
   }
}
