using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] rowsNColumns = Console.ReadLine().Split(", ");
         int rows = int.Parse(rowsNColumns[0]);
         int cols = int.Parse(rowsNColumns[1]);

         int[,] matrix = new int[rows, cols];

         for (int row = 0; row < rows; row++)
         {

            string input = Console.ReadLine();
            string[] inputParts = input.Split(", ");

            for (int col = 0; col < cols; col++)
            {
               matrix[row, col] = int.Parse(inputParts[col]);
            }
         }

         int sum = 0;

         for (int row = 0; row < matrix.GetLength(0); row++)
         {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
               sum += matrix[row, col];
            }
         }

         Console.WriteLine(matrix.GetLength(0));
         Console.WriteLine(matrix.GetLength(1));
         Console.WriteLine(sum);
      }
   }
}
