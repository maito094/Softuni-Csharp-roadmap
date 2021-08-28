using System;

namespace Barcode_Generator_v2
{
   class Program
   {
      static void Main(string[] args)
      {
         int startRange = int.Parse(Console.ReadLine());
         int endRange = int.Parse(Console.ReadLine());
         double[] startArr = new double[4];
         double[] endArr = new double[4];
         double numberStart = 0;
         double curNumStart = 0;
         double numberEnd = 0;
         double curNumEnd = 0;


         for (int j = 3; j >= 0; j--)
         {
            numberStart = Math.Floor((Convert.ToDouble(startRange) / Math.Pow(10, Convert.ToDouble(j))));
            curNumStart = numberStart % 10;
            numberEnd = Math.Floor((Convert.ToDouble(endRange) / Math.Pow(10, Convert.ToDouble(j))));
            curNumEnd = numberEnd % 10;
            startArr[j] = curNumStart;
            endArr[j] = curNumEnd;
         }

         for (double z = startArr[3]; z <= endArr[3]; z++)
         {
            if (z % 2 == 0)
            {
               continue;
            }

            for (double y = startArr[2]; y <= endArr[2]; y++)
            {
               if (y % 2 == 0)
               {
                  continue;
               }

               for (double x = startArr[1]; x <= endArr[1]; x++)
               {
                  if (x % 2 == 0)
                  {
                     continue;
                  }

                  for (double q = startArr[0]; q <= endArr[0]; q++)
                  {
                     if (q % 2 == 0)
                     {
                        continue;
                     }
                     else
                     {
                        Console.Write($"{z}{y}{x}{q} ");

                     }
                  }

               }

            }


         }



      }
   }
}
