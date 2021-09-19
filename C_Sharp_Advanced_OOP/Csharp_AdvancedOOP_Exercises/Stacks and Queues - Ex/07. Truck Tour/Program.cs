using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
   class Program
   {
      static void Main(string[] args)
      {

         int nPetrolPumps = int.Parse(Console.ReadLine());

         Queue<int[]> tourTruck = new Queue<int[]>();

         for (int i = 0; i < nPetrolPumps; i++)
         {

            tourTruck.Enqueue(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
         }

         int indexPumpStation = 0;


         while (true)
         {
            int currentRange = 0;

            foreach (var atruck in tourTruck)
            {
               currentRange += atruck[0];
               currentRange -= atruck[1];

               if (currentRange < 0)
               {
                  tourTruck.Enqueue(tourTruck.Dequeue());
                  indexPumpStation++;

                  break;
               }
            }
            if (currentRange >= 0)
            {
               Console.WriteLine(indexPumpStation);
               break;
            }
         }
      }

   }
}


