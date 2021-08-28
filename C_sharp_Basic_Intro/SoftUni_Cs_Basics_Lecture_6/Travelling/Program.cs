using System;

namespace Travelling
{
   class Program
   {
      static void Main(string[] args)
      {
         string destination = Console.ReadLine();
         double budget = 0;
         double savings = 0;
         while (destination != "End")
         {
            savings = 0;
            budget = double.Parse(Console.ReadLine());

            while (budget > savings)
            {
               savings += double.Parse(Console.ReadLine());

            }
            Console.WriteLine($"Going to {destination}!");
            
            destination = Console.ReadLine();
         }

      }
   }
}
