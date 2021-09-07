using System;

namespace _04._Printing_Triangle
{
   class Program
   {
      static void Main(string[] args)
      {

         int triangleLenght = int.Parse(Console.ReadLine());


         PrintTriangle(triangleLenght);
      }

      static void PrintTriangle(int n)
      {
         for (int i = 1; i <= n; i++)
         {
            PrintColumn(i);
         }
         for (int k = n - 1; k >= 1; k--)
         {
            PrintColumn(k);
         }
      }

      private static void PrintColumn(int i)
      {
         for (int j = 1; j <= i; j++)
         {
            Console.Write(j + " ");
         }
         Console.WriteLine();
      }
   }
}
