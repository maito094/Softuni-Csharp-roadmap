using System;

namespace Maiden_Party
{
   class Program
   {
      static void Main(string[] args)
      {
         double priceMaidenParty = double.Parse(Console.ReadLine());
         int numLoveLetter = int.Parse(Console.ReadLine());    //0.60lv
         int numWaxRoses = int.Parse(Console.ReadLine());      //7.20
         int numKeychains = int.Parse(Console.ReadLine());     //3.60
         int numCharicatures = int.Parse(Console.ReadLine());  //18.20
         int numLuckySurprises = int.Parse(Console.ReadLine());//22.00

         int discount = 0;
         double moneyEarned = 0;
         if (numLoveLetter+numWaxRoses+numKeychains+numCharicatures+numLuckySurprises>=25)
         {
            discount = 35;
         }

         moneyEarned = numLoveLetter * 0.6 + numWaxRoses * 7.20 + numKeychains * 3.6 + numCharicatures * 18.20 + numLuckySurprises * 22;
         moneyEarned = moneyEarned * (1 - discount * 1.0 / 100);
         moneyEarned = moneyEarned * 0.9;
         if (moneyEarned>=priceMaidenParty)
         {
            Console.WriteLine($"Yes! {(moneyEarned - priceMaidenParty):f2} lv left.");
         }
         else
         {
         Console.WriteLine($"Not enough money! {Math.Abs(moneyEarned - priceMaidenParty):f2} lv needed.");

         }
      }
   }
}
