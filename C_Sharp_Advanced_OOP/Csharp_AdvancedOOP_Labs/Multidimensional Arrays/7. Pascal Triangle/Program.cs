using System;

namespace _7._Pascal_Triangle
{
   class Program
   {
      static void Main(string[] args)
      {

         int numRows = int.Parse(Console.ReadLine());

         long[][] pascal = new long[numRows][];


         pascal[0] = new long[1];
         pascal[0][0] = 1;


         for (int i = 1; i < numRows; i++)
         {

            pascal[i] = new long[i + 1];

            pascal[i][0] = 1;
            pascal[i][pascal[i].Length - 1] = 1;

            for (int j = 1; j < pascal[i - 1].Length; j++)
            {
               pascal[i][j] += pascal[i - 1][j - 1] + pascal[i - 1][j];
            }
         }

         foreach (var arr in pascal)
         {
            Console.WriteLine(string.Join(" ", arr));

         }
      }
   }
}
