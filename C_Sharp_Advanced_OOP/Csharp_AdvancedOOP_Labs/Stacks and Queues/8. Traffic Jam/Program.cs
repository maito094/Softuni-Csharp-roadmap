using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
   class Program
   {
      static void Main(string[] args)
      {
         int numOfPassingCars = int.Parse(Console.ReadLine());

         Queue<string> cars = new Queue<string>();

         int carsHavePassed = 0;
         while (true)
         {

            string cmd = Console.ReadLine();
            if (cmd == "end")
            {
               break;
            }
            else if (cmd == "green")
            {
               for (int i = 0; i < numOfPassingCars; i++)
               {
                  if (cars.Count < 1)
                  {
                     continue;
                  }
                  var car = cars.Dequeue();
                  Console.WriteLine(car + " passed!");
                  carsHavePassed++;
               }
            }
            else
            {
               var car = cmd;
               cars.Enqueue(car);
            }


         }
         Console.WriteLine(carsHavePassed + " cars passed the crossroads.");
      }
   }
}
