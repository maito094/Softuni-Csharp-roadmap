using System;
using System.Numerics;

namespace _02._Big_Factorial
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());
         FactorialCalc factorial = new FactorialCalc(n);

         Console.WriteLine(factorial.CalcFactorial());
      }

   }
   class FactorialCalc
   {

      public FactorialCalc(int n)
      {
         N = n;
      }
      public int N { get; set; }
      public BigInteger CalcFactorial()
      {
         BigInteger factorial = 1;
         for (int i = 2; i <= N; i++)
         {
            factorial *= i;
         }
         return factorial;
      }
   }
}
