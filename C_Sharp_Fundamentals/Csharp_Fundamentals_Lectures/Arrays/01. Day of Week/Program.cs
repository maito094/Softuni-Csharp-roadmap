using System;

namespace _01._Day_of_Week
{
   class Program
   {
      static void Main(string[] args)
      {
         int numDay = int.Parse(Console.ReadLine());

         string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };


         if (numDay > 0 && numDay < 8)
         {

            Console.WriteLine(dayOfWeek[numDay - 1]);
         }
         else
         {
            Console.WriteLine("Invalid day!");
         }
      }
   }
}
