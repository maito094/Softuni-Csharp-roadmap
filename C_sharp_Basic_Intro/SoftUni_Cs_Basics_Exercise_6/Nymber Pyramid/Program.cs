using System;

namespace Nymber_Pyramid
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());
         int intermediate = 0;

         for (int row = 1; row <= n; row++)
         {

            for (int col = 1; col <= row; col++)
            {
               intermediate++;
               if (intermediate > n)
               {
                  Console.WriteLine();
                  return;
               }
               Console.Write(intermediate + " ");

            }


            Console.WriteLine();
         }
      }
   }
}
