using System;

namespace Combinations
{
   class Program
   {
      static void Main(string[] args)
      {
         //n - input  ; x1+x2+x3=n equation ; c = number of combination of found solution of the equation

         int n = int.Parse(Console.ReadLine());
         int c = 0;
         for (int x1 = 0; x1 <= n; x1++)
         {
            for (int x2 = 0; x2 <= n; x2++)
            {
               for (int x3 = 0; x3 <= n; x3++)
               {
                  if ((x1+x2+x3)==n)
                  {
                     c++;
                  }
               }
            }
         }

         Console.WriteLine(c);
      }
   }
}
