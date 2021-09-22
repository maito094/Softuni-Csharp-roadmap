using System;

namespace _3._Primary_Diagonal
{
   class Program
   {
      static void Main(string[] args)
      {
         int nSquare = int.Parse(Console.ReadLine());

         int sum = 0;
         int[,] matrix = new int[nSquare, nSquare];

         for (int row = 0; row < nSquare; row++)
         {
            string[] input = Console.ReadLine().Split(" ");


            for (int col = 0; col < nSquare; col++)
            {

               matrix[row, col] = int.Parse(input[col]);

            }
         }

         for (int row = 0; row < nSquare; row++)
         {
            for (int col = 0; col < nSquare; col++)
            {
               if (row == col)
               {
                  sum += matrix[row, col];
               }
            }
         }
         Console.WriteLine(sum);
      }
   }
}
