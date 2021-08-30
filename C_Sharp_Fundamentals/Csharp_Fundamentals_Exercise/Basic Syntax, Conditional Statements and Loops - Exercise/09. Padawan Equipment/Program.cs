using System;

namespace _09._Padawan_Equipment
{
   class Program
   {
      static void Main(string[] args)
      {
         double amountMoney = double.Parse(Console.ReadLine());
         int cntStudents = int.Parse(Console.ReadLine());
         double priceSabers = double.Parse(Console.ReadLine());
         double priceRobes = double.Parse(Console.ReadLine());
         double priceBelts = double.Parse(Console.ReadLine());

         double totalprice = (Math.Ceiling(cntStudents * 1.10) * priceSabers) +
                             (cntStudents * priceRobes) +
                             //(cntStudents * priceBelts - (priceBelts * (cntStudents / 6)));
                             (priceBelts * (cntStudents - (cntStudents / 6)));


         if (totalprice <= amountMoney)
         {
            Console.WriteLine($"The money is enough - it would cost {totalprice:f2}lv.");
         }
         else
         {
            Console.WriteLine($"John will need {(totalprice - amountMoney):f2}lv more.");
         }
      }
   }
}
