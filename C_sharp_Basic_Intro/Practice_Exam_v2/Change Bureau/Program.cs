using System;

namespace Change_Bureau
{
   class Program
   {
      static void Main(string[] args)
      {
         int numBTC = int.Parse(Console.ReadLine());  // 1BTC =1168lv   ; 1.95lv = 1 euro
         double numChineseYuan = double.Parse(Console.ReadLine());// 1Yuan = 0.15$ 1.76lv == 1 $
         double commission = double.Parse(Console.ReadLine());
         double dollar = 0;
         double euro = 0;

         dollar = numChineseYuan * 0.15;//yuan to $
         dollar = dollar * 1.76; // $ to bgn
         euro = numBTC * 1168.0 / 1.95 + dollar / 1.95;
         euro = euro * (1 - commission * 1.0 / 100);
         Console.WriteLine($"{euro:f2}");
      }
   }
}
