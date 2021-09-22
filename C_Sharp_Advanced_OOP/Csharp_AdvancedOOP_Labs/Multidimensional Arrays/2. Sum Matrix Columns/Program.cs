using System;

namespace _2._Sum_Matrix_Columns
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] rowsNColumns = Console.ReadLine().Split(", ");
         int rows = int.Parse(rowsNColumns[0]);
         int cols = int.Parse(rowsNColumns[1]);

         int[,] matrix = new int[rows, cols];

         int[] colSums = new int[cols];

         for (int row = 0; row < rows; row++)
         {

            string input = Console.ReadLine();
            string[] inputParts = input.Split(" ");

            for (int col = 0; col < cols; col++)
            {
               matrix[row, col] = int.Parse(inputParts[col]);
            }
         }


         for (int row = 0; row < matrix.GetLength(0); row++)
         {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
               colSums[col] += matrix[row, col];
            }
         }

         foreach (var sum in colSums)
         {

            Console.WriteLine(sum);
         }
      }
   }
}
