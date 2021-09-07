using System;

namespace _08._Math_Power
{
   class Program
   {
      static void Main(string[] args)
      {
         double numPow = MathPower(double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
         Console.WriteLine(numPow);
      }
      static double MathPower(double number, int power)
      {
         double result = 1;
         for (int i = 0; i < power; i++)
         {
            result *= number;

         }
         return result;
      }
   }
}
