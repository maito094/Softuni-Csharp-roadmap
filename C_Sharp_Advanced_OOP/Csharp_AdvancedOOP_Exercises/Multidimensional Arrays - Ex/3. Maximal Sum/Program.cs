using System;
using System.Linq;

namespace _3._Maximal_Sum
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] size = Console.ReadLine()
                             .Split(" ")
                             .Select(int.Parse)
                             .ToArray();

         int[,] matrix = new int[size[0], size[1]];

         int startRow = 0;
         int startCol = 0;

         for (int row = 0; row < matrix.GetLength(0); row++)
         {
            var inputRow = Console.ReadLine().Split(" ");

            for (int column = 0; column < matrix.GetLength(1); column++)
            {
               var numbers = int.Parse(inputRow[column]);

               matrix[row, column] = numbers;
            }

         }

         int maxSum = int.MinValue;

         for (int row = 0; row < matrix.GetLength(0) - 2; row++)
         {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
               int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
               if (currentSum > maxSum)
               {
                  maxSum = currentSum;
                  startRow = row;
                  startCol = col;
               }
            }
         }

         Console.WriteLine($"Sum = {maxSum}");

         for (int i = startRow; i < startRow + 3; i++)
         {
            for (int j = startCol; j < startCol + 3; j++)
            {
               Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
         }
      }
   }
}
