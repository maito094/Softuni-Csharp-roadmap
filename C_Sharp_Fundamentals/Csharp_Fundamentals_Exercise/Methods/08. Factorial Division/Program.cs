using System;
using System.Numerics;

namespace _08._Factorial_Division
{
   class Program
   {
      static void Main(string[] args)
      {
         int firstNum = int.Parse(Console.ReadLine());
         int secondNum = int.Parse(Console.ReadLine());

         double result = 0;

        long factorialOfFirst = Factorial(firstNum);
         long factorialOfSecond = Factorial(secondNum);

         result = Division(factorialOfFirst, factorialOfSecond);

         Console.WriteLine($"{result:f2}");
      }

      static long Factorial(int num)
      {
         long factorial = 1;

         for (int i = 1; i <= num; i++)
         {
            factorial *= i;
         }
         return factorial;
      }
      static double Division(long num1, long num2)
         => (double)(num1*1.0 / num2);
   }
}
