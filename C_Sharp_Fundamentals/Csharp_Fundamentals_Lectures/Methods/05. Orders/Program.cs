using System;

namespace _05._Orders
{
   class Program
   {
      static void Main(string[] args)
      {
         string item = Console.ReadLine();
         int quantity = int.Parse(Console.ReadLine());
         CalcTotalPrice(item, quantity);
      }

      static void CalcTotalPrice(string item, int quantity)
      {
         double sum = 0;
         switch (item)
         {

            case "coffee":
               sum += 1.50;
               break;
            case "water":
               sum += 1.00;
               break;
            case "coke":
               sum += 1.40;
               break;
            case "snacks":
               sum += 2.00;
               break;

            default:
               break;
         }
         sum *= quantity;

         Console.WriteLine($"{sum:F2}");
      }
   }
}
