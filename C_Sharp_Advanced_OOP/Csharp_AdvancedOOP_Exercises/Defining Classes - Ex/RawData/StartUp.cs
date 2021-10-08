using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
   {
      public static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());
         List<Car> cars = new List<Car>();

         for (int i = 0; i < n; i++)
         {
            //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} " +
            //   "{tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} " +
            //   "{tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"

            string[] line = Console.ReadLine().Split();
            string model = line[0];
            int engineSpeed = int.Parse(line[1]);
            int enginePower = int.Parse(line[2]);
            int cargoWeight = int.Parse(line[3]);
            string cargoType = line[4];
            double tire1Pressure = double.Parse(line[5]);
            int tire1Age = int.Parse(line[6]);
            double tire2Pressure = double.Parse(line[7]);
            int tire2Age = int.Parse(line[8]);
            double tire3Pressure = double.Parse(line[9]);
            int tire3Age = int.Parse(line[10]);
            double tire4Pressure = double.Parse(line[11]);
            int tire4Age = int.Parse(line[12]);


            Engine engineCar = new Engine(engineSpeed, enginePower);
            Cargo cargoCar = new Cargo(cargoType, cargoWeight);
            Tires tire1 = new Tires(tire1Age, tire1Pressure);
            Tires tire2 = new Tires(tire2Age, tire2Pressure);
            Tires tire3 = new Tires(tire3Age, tire3Pressure);
            Tires tire4 = new Tires(tire4Age, tire4Pressure);
            List<Tires> tires = new List<Tires>() { tire1, tire2, tire3, tire4 };

            Car car = new Car(model, engineCar, cargoCar, tires);

            cars.Add(car);
         }

         string command = Console.ReadLine();

         if (command == "fragile")
         {
            List<Car> fragileCars = cars.Where(x => x.Cargo.Type == command).Where(x => x.Tires.Any(p => p.Pressure < 1)).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, fragileCars.Select(x => x.Model)));
         }
         else if (command == "flammable")
         {
            List<Car> flammableCars = cars.Where(x => x.Cargo.Type == command).Where(x => x.Engine.Power > 250).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, flammableCars.Select(x => x.Model)));
         }
      }
   }
}
