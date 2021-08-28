using System;

namespace Suitcases_Load
{
   class Program
   {
      static void Main(string[] args)
      {
         double capacityLoad = double.Parse(Console.ReadLine());
         string cmd = "";
         double volumeLuggage = 0;
         int n = 1;
         while (volumeLuggage <= capacityLoad)
         {
            cmd = Console.ReadLine();

            if (cmd == "End")
            {

               Console.WriteLine("Congratulations! All suitcases are loaded!");
               break;
            }

            if (n % 3 == 0)
            {

               volumeLuggage += double.Parse(cmd) * 1.10;

            }
            else
            {
               volumeLuggage += double.Parse(cmd);

            }
            if (volumeLuggage > capacityLoad)
            {

               Console.WriteLine("No more space!");
               break;
            }
            n++;

         }
         Console.WriteLine($"Statistic: {n-1} suitcases loaded.");
      }
   }
}
