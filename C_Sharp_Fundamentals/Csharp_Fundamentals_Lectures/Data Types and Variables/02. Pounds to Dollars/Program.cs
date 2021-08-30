using System;

namespace _02._Pounds_to_Dollars
{
   class Program
   {
      static void Main(string[] args)
      {
         //1 British Pound = 1.31 Dollars
         decimal britPounds = decimal.Parse(Console.ReadLine());
         decimal dollars = britPounds * 1.31m;

         Console.WriteLine($"{dollars:f3}");
      }
   }
}
