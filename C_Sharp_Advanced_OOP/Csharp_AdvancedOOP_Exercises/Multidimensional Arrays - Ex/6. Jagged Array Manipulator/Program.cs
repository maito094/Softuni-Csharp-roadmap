using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
   class Program
   {
      static void Main(string[] args)
      {

         int numRows = int.Parse(Console.ReadLine());

         double[][] jaggedArray = new double[numRows][];

         for (int row = 0; row < numRows; row++)
         {
            var numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();



            //jaggedArray[row] = new int[numbers.Length];

            //for (int col = 0; col < numbers.Length; col++)
            //{

            //   jaggedArray[row][col] = numbers[col];
            //}

            // This above can be replaced with just this:
            jaggedArray[row] = numbers;

         }

         for (int row = 0; row < jaggedArray.Length - 1; row++)
         {

            if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
            {
               for (int col = 0; col < jaggedArray[row].Length; col++)
               {
                  jaggedArray[row][col] *= 2;
                  jaggedArray[row + 1][col] *= 2;
               }
            }
            else
            {
               for (int col = 0; col < jaggedArray[row].Length; col++)
               {
                  jaggedArray[row][col] /= 2;

               }

               for (int col = 0; col < jaggedArray[row + 1].Length; col++)
               {
                  jaggedArray[row + 1][col] /= 2;
               }
            }
         }

         while (true)
         {
            string[] arguments = Console.ReadLine().Split(" ");
            string action = arguments[0];

            if (action == "End")
            {
               break;
            }

            int row = int.Parse(arguments[1]);
            int col = int.Parse(arguments[2]);
            int value = int.Parse(arguments[3]);

            if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
            {

               if (action == "Add")
               {
                  jaggedArray[row][col] += value;
               }
               else
               {
                  jaggedArray[row][col] -= value;
               }
            }

         }

         for (int row = 0; row < jaggedArray.Length; row++)
         {
            Console.WriteLine(string.Join(" ", jaggedArray[row]));
         }

      }
   }
}
