using System;

namespace Vacation
{
   class Program
   {
      static void Main(string[] args)
      {
         double moneyVacation = double.Parse(Console.ReadLine());
         double moneyAvailable = double.Parse(Console.ReadLine());
         double currentMoney = 0;
         string action = "";

         int spending = 0;
         int saving = 0;

         while (moneyAvailable < moneyVacation && spending < 5)
         {
            action = Console.ReadLine();
            currentMoney = double.Parse(Console.ReadLine());
            saving++;

            if (action == "spend")
            {
               spending++;

               moneyAvailable -= currentMoney;

               if (moneyAvailable < 0)
               {
                  moneyAvailable = 0;
               }
            }
            else if (action == "save")
            {

               spending = 0;  //reset spending iteration

               moneyAvailable += currentMoney;

            }
         }
         if (spending == 5)
         {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine($"{saving}");

         }
         if (moneyAvailable >= moneyVacation)
         {
            Console.WriteLine($"You saved the money for {saving} days.");
         }

      }

   }
}
