using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

         string[,] matrix = new string[size[0], size[1]];

         bool fValid = true;
         for (int row = 0; row < matrix.GetLength(0); row++)
         {
            var input = Console.ReadLine().Split(" ");

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
               matrix[row, col] = input[col];
            }
         }

         while (true)
         {
            string[] input = Console.ReadLine().Split(" ");
            string cmd = input[0];

            if (cmd == "END")
            {
               break;
            }

            if (input.Length == 5 && cmd == "swap")
            {

               int row1 = int.Parse(input[1]);
               int col1 = int.Parse(input[2]);
               int row2 = int.Parse(input[3]);
               int col2 = int.Parse(input[4]);
               if (isValidInput(matrix, row1, col1, row2, col2))
               {
                  string swapTemp = matrix[row1, col1];
                  matrix[row1, col1] = matrix[row2, col2];
                  matrix[row2, col2] = swapTemp;

                  fValid = true;
               }
               else
               {
                  fValid = false;
               }

            }
            else
            {
               fValid = false;
            }

            if (!fValid)
            {

               Console.WriteLine("Invalid input!");
               continue;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

               for (int col = 0; col < matrix.GetLength(1); col++)
               {
                  Console.Write(matrix[row, col] + " ");
               }

               Console.WriteLine();
            }

         }

      }

      private static bool isValidInput(string[,] matrix, int row1, int col1, int row2, int col2)
      {
         return row1 >= 0 && row1 < matrix.GetLength(0) && col1 >= 0 && col1 < matrix.GetLength(1) &&
                row2 >= 0 && row2 < matrix.GetLength(0) && col2 >= 0 && col2 < matrix.GetLength(1);
      }
   }
}
