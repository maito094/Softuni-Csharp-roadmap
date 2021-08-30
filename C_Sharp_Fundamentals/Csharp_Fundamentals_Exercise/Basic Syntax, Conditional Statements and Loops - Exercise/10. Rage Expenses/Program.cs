using System;

namespace _10._Rage_Expenses
{
   class Program
   {
      static void Main(string[] args)
      {
         int lostGamesCnt = int.Parse(Console.ReadLine());
         double headsetPrice = double.Parse(Console.ReadLine());
         double mousePrice = double.Parse(Console.ReadLine());
         double keyboardPrice = double.Parse(Console.ReadLine());
         double displayPrice = double.Parse(Console.ReadLine());
         double total = 0;

         total += (headsetPrice * (lostGamesCnt / 2)) +
          (mousePrice * (lostGamesCnt / 3)) +
          (keyboardPrice * (lostGamesCnt / 6)) +
          (displayPrice * (lostGamesCnt / 12));

         Console.WriteLine($"Rage expenses: {total:f2} lv.");
      }
   }
}
