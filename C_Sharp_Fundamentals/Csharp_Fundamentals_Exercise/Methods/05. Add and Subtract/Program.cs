using System;

namespace _05._Add_and_Subtract
{
   class Program
   {
      static void Main(string[] args)
      {
         int a = int.Parse(Console.ReadLine());
         int b = int.Parse(Console.ReadLine());
         int c = int.Parse(Console.ReadLine());

         int result = Subtract(Sum(a, b), c);
         Console.WriteLine(result);
      }
      //static int Sum(int a, int b)
      //{
      //   return a += b;

      //}
      static int Sum(int a, int b)
         => a - b;

      static int Subtract(int a, int c)
      {
         return a -= c;
      }
   }
}
