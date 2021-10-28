namespace NeedForSpeed
{
   public class StartUp
   {
      public static void Main(string[] args)
      {

         Vehicle v = new Vehicle(100, 100);   //1.25 * km =125 => -25 Fuel
         v.Drive(100);
         Car car = new Car(100, 100);      //3*km =300 => -200 fuel
         car.Drive(100);

         SportCar sports = new SportCar(100,100);   // 10*km = 1000 => -900 fuel
         sports.Drive(100);

      }
   }
}
