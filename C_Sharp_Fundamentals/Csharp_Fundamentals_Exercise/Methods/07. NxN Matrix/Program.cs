using System;

namespace _07._NxN_Matrix
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());
         printNxNMatrix(n);
      }

      private static void printNxNMatrix(int n)
      {
         for (int i = 0; i < n; i++)
         {
            for (int j = 0; j < n; j++)
            {
               Console.Write(string.Concat(n.ToString(), " "));

            }
            Console.WriteLine();
         }
      }
   }
}
