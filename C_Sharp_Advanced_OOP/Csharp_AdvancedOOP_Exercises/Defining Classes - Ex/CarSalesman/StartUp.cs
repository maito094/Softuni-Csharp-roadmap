using System;
using System.Collections.Generic;

namespace DefiningClasses

{
   public class StartUp
   {
      public static string isNullorZero(string parameter)
      {
         if (parameter == null)
         {
            return @"n/a";
         }
         return parameter;
      }
      public static string isNullorZero(int parameter)
      {
         if (parameter == 0)
         {
            return @"n/a";
         }
         return parameter.ToString();
      }
      static void Main(string[] args)
      {
         int numOfEngines = int.Parse(Console.ReadLine());
         Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
         List<Car> cars = new List<Car>();

         for (int i = 0; i < numOfEngines; i++)
         {
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string modelEngine = line[0];
            int powerEngine = int.Parse(line[1]);

            //Optional parameters
            if (line.Length == 3)
            {
               if (char.IsDigit(line[2][0]))
               {

                  int displacementEngine = int.Parse(line[2]);

                  engines.Add(modelEngine, new Engine(modelEngine, powerEngine, displacementEngine));
               }
               else
               {
                  string efficiencyEngine = line[2];
                  engines.Add(modelEngine, new Engine(modelEngine, powerEngine, efficiencyEngine));
               }
            }
            else if (line.Length == 4)
            {
               int displacementEngine = int.Parse(line[2]);
               string efficiencyEngine = line[3];
               engines.Add(modelEngine, new Engine(modelEngine, powerEngine, displacementEngine, efficiencyEngine));
            }
            else
            {
               engines.Add(modelEngine, new Engine(modelEngine, powerEngine));
            }

         }

         int numOfCars = int.Parse(Console.ReadLine());

         for (int i = 0; i < numOfCars; i++)
         {
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string carModel = line[0];
            string engine = line[1];

            //Optional parameters
            if (line.Length == 3)
            {
               if (char.IsDigit(line[2][0]))
               {

                  int carWeight = int.Parse(line[2]);

                  cars.Add(new Car(carModel, engines[engine], carWeight));
               }
               else
               {
                  string carColor = line[2];
                  cars.Add(new Car(carModel, engines[engine], carColor));
               }
            }
            else if (line.Length == 4)
            {
               int carWeight = int.Parse(line[2]);
               string carColor = line[3];
               cars.Add(new Car(carModel, engines[engine], carWeight, carColor));
            }
            else
            {
               cars.Add(new Car(carModel, engines[engine]));
            }

         }

         foreach (var car in cars)
         {
            Console.Write(car.ToString());
         }
      }
   }
}
