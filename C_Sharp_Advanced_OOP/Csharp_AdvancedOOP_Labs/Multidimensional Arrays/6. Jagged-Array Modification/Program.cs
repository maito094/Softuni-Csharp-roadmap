using System;

namespace _6._Jagged_Array_Modification
{
   class Program
   {
      static void Main(string[] args)
      {
         int matrixRows = int.Parse(Console.ReadLine());

         int[][] jaggedArray = new int[matrixRows][];

         for (int i = 0; i < matrixRows; i++)
         {
            var line = Console.ReadLine().Split(" ");
            jaggedArray[i] = new int[line.Length];

            for (int j = 0; j < line.Length; j++)
            {
               var numbers = int.Parse(line[j]);
               jaggedArray[i][j] = numbers;
            }
         }

         while (true)
         {
            var command = Console.ReadLine().Split(" ");
            if (command[0] == "END")
            {
               break;
            }

            int row = int.Parse(command[1]);
            int col = int.Parse(command[2]);
            int value = int.Parse(command[3]);

            if (row < 0 || row > matrixRows - 1 || col < 0 || col > jaggedArray[row].Length - 1)
            {
               Console.WriteLine("Invalid coordinates");
               continue;
            }

            if (command[0] == "Add")
            {
               jaggedArray[row][col] += value;
            }

            else if (command[0] == "Subtract")
            {
               jaggedArray[row][col] -= value;
            }
         }

         foreach (var arr in jaggedArray)
         {
            Console.WriteLine(string.Join(" ", arr));
         }

      }
   }
}
