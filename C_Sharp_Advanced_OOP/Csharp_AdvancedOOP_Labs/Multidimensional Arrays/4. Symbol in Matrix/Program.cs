using System;

namespace _4._Symbol_in_Matrix
{
   class Program
   {
      static void Main(string[] args)
      {
         int nMatrix = int.Parse(Console.ReadLine());

         char[,] ASCIIMatrix = new char[nMatrix, nMatrix];

         for (int row = 0; row < nMatrix; row++)
         {
            string input = Console.ReadLine();

            for (int col = 0; col < nMatrix; col++)
            {
               ASCIIMatrix[row, col] = input[col];
            }
         }

         char symbol = char.Parse(Console.ReadLine());
         bool isFoundSymbol = false;
         int rowFound = 0;
         int colFound = 0;

         for (int row = 0; row < ASCIIMatrix.GetLength(0); row++)
         {
            for (int col = 0; col < ASCIIMatrix.GetLength(1); col++)
            {
               if (ASCIIMatrix[row, col] == symbol)
               {
                  isFoundSymbol = true;
                  rowFound = row;
                  colFound = col;
                  break;
               }
            }
            if (isFoundSymbol)
            {
               break;
            }
         }
         if (isFoundSymbol)
         {

            Console.WriteLine($"({rowFound}, {colFound})");
         }
         else
         {
            Console.WriteLine($"{symbol} does not occur in the matrix ");
         }
      }
   }
}
