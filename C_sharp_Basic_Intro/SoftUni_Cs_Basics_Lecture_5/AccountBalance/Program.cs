using System;

namespace AccountBalance
{
   class Program
   {
      static void Main(string[] args)
      {
         double sum = 0;
         double deposit = 0;
         string cmd = Console.ReadLine();

         while (cmd != "NoMoreMoney")
         {

            deposit = double.Parse(cmd);
            if (deposit < 0)
            {
               Console.WriteLine("Invalid operation!");
               break;
            }
            Console.WriteLine($"Increase: {deposit:0.00}");
            sum += deposit;
            cmd = Console.ReadLine();
         }
         Console.WriteLine($"Total: {Math.Round(sum, 2):0.00}");
      }
   }
}
