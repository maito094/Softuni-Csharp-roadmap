using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
   class Program
   {
      static void Main(string[] args)
      {

         int sizeMatrix = int.Parse(Console.ReadLine());

         int[,] matrix = new int[sizeMatrix, sizeMatrix];

         int sumPrimaryDiagonal = 0;
         int sumSecondaryDiagonal = 0;
         int absoluteDifferance = 0;

         int counter = matrix.GetLength(1) - 1;

         for (int i = 0; i < sizeMatrix; i++)
         {
            int[] inputIntegers = Console.ReadLine()
                                         .Split(" ")
                                         .Select(int.Parse)
                                         .ToArray();


            for (int j = 0; j < sizeMatrix; j++)
            {
               matrix[i, j] = inputIntegers[j];

               if (i == j)
               {
                  sumPrimaryDiagonal += matrix[i, j];
               }

            }

            sumSecondaryDiagonal += matrix[i, counter];
            counter--;
         }

         absoluteDifferance = Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal);
         Console.WriteLine(absoluteDifferance);
      }
   }
}
