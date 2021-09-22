using System;

namespace _5._Square_With_Maximum_Sum
{
   class Program
   {
      static void Main(string[] args)
      {

         string[] rowsNColumns = Console.ReadLine().Split(", ");
         int rows = int.Parse(rowsNColumns[0]);
         int cols = int.Parse(rowsNColumns[1]);

         int[,] matrix = new int[rows, cols];


         string[] subRowsNColumns = Console.ReadLine().Split(", ");
         int subRows = int.Parse(subRowsNColumns[0]);
         int subCols = int.Parse(subRowsNColumns[1]);

         int[,] subMatrix = new int[subRows, subCols]; //Take all Elements Sum it and find which is the biggest of all sub matrices;


         for (int row = 0; row < rows; row++)
         {

            string input = Console.ReadLine();
            string[] inputParts = input.Split(", ");

            for (int col = 0; col < cols; col++)
            {
               matrix[row, col] = int.Parse(inputParts[col]);
            }
         }

         long maxSum = long.MinValue;

         for (int row = 0; row < matrix.GetLength(0) - subMatrix.GetLength(0) + 1; row++)
         {
            for (int col = 0; col < matrix.GetLength(1) - subMatrix.GetLength(1) + 1; col++)
            {
               var sum = 0;//= matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
               for (int i = 0; i < subRows; i++)
               {
                  for (int j = 0; j < subCols; j++)
                  {
                     sum += matrix[row + i, col + j];
                  }
               }
               /***********************************/

               if (sum > maxSum)
               {
                  maxSum = sum;

                  for (int subRow = 0; subRow < subMatrix.GetLength(0); subRow++)
                  {
                     for (int subCol = 0; subCol < subMatrix.GetLength(1); subCol++)
                     {
                        subMatrix[subRow, subCol] = matrix[row + subRow, col + subCol];
                     }
                  }
               }
            }
         }
         for (int subRow = 0; subRow < subMatrix.GetLength(0); subRow++)
         {
            for (int subCol = 0; subCol < subMatrix.GetLength(1); subCol++)
            {
               Console.Write($"{subMatrix[subRow, subCol]} ");
            }
            Console.WriteLine();
         }
         Console.WriteLine(maxSum);
      }
   }
}
