using System;

namespace Building
{
   class Program
   {
      static void Main(string[] args)
      {
         int numFloors = int.Parse(Console.ReadLine());
         int numRooms = int.Parse(Console.ReadLine()) - 1;
         char type = ' ';
         for (int i = numFloors; i >= 1; i--)
         {
            for (int j = 0; j <= numRooms; j++)
            {
               if (numFloors == i)
               {
                  type = 'L';
               }
               else if (i % 2 == 0)
               {
                  type = 'O';
               }
               else
               {
                  type = 'A';
               }
               Console.Write($"{type}" + $"{(i * 10) + j} ");
            }
            Console.WriteLine();
         }

      }
   }
}
