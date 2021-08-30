using System;

namespace _03._Elevator
{
   class Program
   {
      static void Main(string[] args)
      {
         int nPersons = int.Parse(Console.ReadLine());
         int pCapacity = int.Parse(Console.ReadLine());


         Console.WriteLine($"{Math.Ceiling((double)nPersons/pCapacity) }");
      }
   }
}
