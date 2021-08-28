using System;

namespace Special_Numbers
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());
         int lastDigit = 0;
         int specialDigit = 0;
         for (int i = 1111; i <= 9999; i++)
         {
            specialDigit = 0;
            int currentNum = i;

            for (int j = 4; j >= 1; j--)
            {

               lastDigit = currentNum % 10;
               currentNum = currentNum / 10;

               if (lastDigit == 0)
               {
                  break;
               }

               if (n % lastDigit == 0)
               {
                  specialDigit++;
                  if (specialDigit == 4)
                  {

                     Console.Write(i + " ");
                  }
               }
            }

         }
      }
   }
}
