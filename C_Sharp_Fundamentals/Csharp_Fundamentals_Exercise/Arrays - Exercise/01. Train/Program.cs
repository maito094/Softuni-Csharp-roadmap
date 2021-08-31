using System;

namespace _01._Train
{
   class Program
   {
      static void Main(string[] args)
      {
         int wagonsNum = int.Parse(Console.ReadLine());

         int[] wagons = new int[wagonsNum];
         int sum = 0;

         for (int i = 0; i < wagonsNum; i++)
         {
            wagons[i] = int.Parse(Console.ReadLine());
            sum += wagons[i];
         }

         Console.WriteLine(string.Join(" ", wagons));

         Console.WriteLine(sum);
      }
   }
}
