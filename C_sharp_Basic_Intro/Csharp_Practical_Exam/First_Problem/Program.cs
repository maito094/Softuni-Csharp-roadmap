using System;

namespace First_Problem
{
   class Program
   {
      static void Main(string[] args)
      {
         int rollsPaper = int.Parse(Console.ReadLine()); //5.80lv per piece
         int rollsCloth = int.Parse(Console.ReadLine());//7.20lv per piece
         double litresGlue = double.Parse(Console.ReadLine());//1.20lv per litre
         int percentDiscount = int.Parse(Console.ReadLine());

         double sumresult = 0;

         sumresult = rollsPaper * 5.80 + rollsCloth * 7.20 + litresGlue * 1.20;
         sumresult = sumresult * (1 - percentDiscount * 1.0 / 100);
         Console.WriteLine($"{sumresult:f3}");
      }
   }
}
