using System;

namespace _07._Vending_Machine
{
   class Program
   {
      static void Main(string[] args)
      {
         string cmd = Console.ReadLine();

         double sumCoin = 0;
         double priceSubstract = 0;
         while (cmd != "Start")
         {
            if (cmd != "0.1" && cmd != "0.2" && cmd != "0.5" && cmd != "1" && cmd != "2")
            {
               Console.WriteLine($"Cannot accept {cmd}");
            }
            else
            {
               sumCoin += double.Parse(cmd);
            }
            cmd = Console.ReadLine();

         }
         cmd = Console.ReadLine();
         while (cmd != "End")
         {
            if (cmd == "Nuts")
            {
               priceSubstract = 2.0;
            }
            else if (cmd == "Water")
            {
               priceSubstract = 0.7;
            }
            else if (cmd == "Crisps")
            {
               priceSubstract = 1.5;
            }
            else if (cmd == "Soda")
            {
               priceSubstract = 0.8;
            }
            else if (cmd == "Coke")
            {
               priceSubstract = 1.0;
            }
            else
            {
               Console.WriteLine("Invalid product");
               cmd = Console.ReadLine();
               continue;
            }

            if (sumCoin >= priceSubstract)
            {
               Console.WriteLine($"Purchased {cmd.ToLower()}");
               sumCoin -= priceSubstract;
            }
            else
            {
               Console.WriteLine("Sorry, not enough money");
            }
            cmd = Console.ReadLine();
         }

         Console.WriteLine($"Change: {sumCoin:F2}");
      }
   }
}
