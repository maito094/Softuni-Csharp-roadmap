using System;

namespace Barcode_Generator
{
   class Program
   {
      static void Main(string[] args)
      {
         int startRange = int.Parse(Console.ReadLine());
         int endRange = int.Parse(Console.ReadLine());
         double number = 0;
         double curNum = 0;
         bool bFlag = false;
         for (int i = startRange; i <= endRange; i++)
         {
            bFlag = false;
            for (int j = 0; j <= 3; j++)
            {
               number = Math.Floor((Convert.ToDouble(i) / Math.Pow(10, Convert.ToDouble(j))));
               curNum = number % 10;


               if (curNum % 2 == 0 || curNum == 0)
               {
                  bFlag = true;
                  break;
               }

            }

            if (bFlag)
            {

               continue;
            }
            else
            {
               Console.WriteLine(i + " ");

            }
         }
      }
   }
}
