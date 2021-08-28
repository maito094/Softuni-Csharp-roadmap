using System;

namespace Everest
{
   class Program
   {
      static void Main(string[] args)
      {
         const int mountEverest = 8848;
         string cmd = Console.ReadLine();//"Yes" or "No"
         int metersClimbed = 5364;
         // metersClimbed += int.Parse(Console.ReadLine());

         int timesClimbedInRow = 1;

         while (cmd != "END")
         {

            if (cmd == "Yes")
            {
               timesClimbedInRow++;
               if (timesClimbedInRow > 5)
               {
                  break;
               }
            }

            metersClimbed += int.Parse(Console.ReadLine());
            if (metersClimbed >= mountEverest)
            {
               break;
            }
            cmd = Console.ReadLine();
         }

         if (metersClimbed >= mountEverest)
         {
            Console.WriteLine($"Goal reached for {timesClimbedInRow} days!");

         }
         else
         {
            Console.WriteLine("Failed!");
            Console.WriteLine($"{metersClimbed}");

         }
      }
   }
}
