using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
   class Program
   {
      static void Main(string[] args)
      {
         HashSet<string> cars = new HashSet<string>();

         while (true)
         {
            var inputLines = Console.ReadLine().Split(", ");

            if (inputLines[0] == "END")
            {
               break;
            }

            string direction = inputLines[0];
            string carPlate = inputLines[1];


            if (direction == "IN")
            {
               cars.Add(carPlate);
            }
            else if (direction == "OUT")
            {
               cars.Remove(carPlate);
            }

         }

         if (cars.Count > 0)
         {

            foreach (var car in cars)
            {
               Console.WriteLine(car);
            }
         }
         else
         {
            Console.WriteLine("Parking Lot is Empty");
         }
      }
   }
}
