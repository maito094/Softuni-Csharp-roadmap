using System;

namespace Password_Generator
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());
         int l = int.Parse(Console.ReadLine());

         int chr1 = 1;
         int chr2 = 1;
         char chr3 = ' ';
         char chr4 = ' ';
         int chr5 = 1;

         for (int i = 1; i <= n; i++)
         {
            for (int j = 1; j <= n; j++)
            {
               for (int k = 1; k <= l; k++)
               {
                  for (int x = 1; x <= l; x++)
                  {
                     for (int y = Math.Max(i, j) + 1; y <= n; y++)
                     {

                        chr1 = i;
                        chr2 = j;
                        chr3 = Convert.ToChar(k + 96);
                        chr4 = Convert.ToChar(x + 96);
                        chr5 = y;
                        Console.Write($"{chr1}{chr2}{chr3}{chr4}{chr5} ");
                     }
                  }
               }
            }
         }

      }
   }
}
