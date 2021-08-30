using System;

namespace Data_Types_and_Variables
{
   class Program
   {
      static void Main(string[] args)
      {
         decimal meters = decimal.Parse(Console.ReadLine());
         decimal kilometers = meters / 1000.0m;
         Console.WriteLine($"{kilometers:f2}");
      }
   }
}
