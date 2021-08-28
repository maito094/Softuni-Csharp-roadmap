using System;

namespace Sum_of_Two_Numbers
{
   class Program
   {
      static void Main(string[] args)
      {
         int beginInterval = int.Parse(Console.ReadLine());
         int endInterval = int.Parse(Console.ReadLine());
         int magicNumber = int.Parse(Console.ReadLine());
         int combinationNum = 0;
         int rnum1 = 0;
         int rnum2 = 0;
         bool flag = false;
         for (int num1 = beginInterval; num1 <= endInterval; num1++)
         {
            for (int num2 = beginInterval; num2 <= endInterval; num2++)
            {
               combinationNum++;

               if (num1 + num2 == magicNumber)
               {
                  rnum1 = num1;
                  rnum2 = num2;
                  flag = true;
                  break;
               }
            }
            if (flag)
            {
               break;
            }
         }
         if (rnum1 + rnum2 > 0)
         {

            Console.WriteLine($"Combination N:{combinationNum} ({rnum1} + {rnum2} = {magicNumber})");
         }
         else
         {

            //            Console.WriteLine($"{Math.Pow((endInterval - beginInterval),2) + ((endInterval - beginInterval) * 2 + 1)} combinations - neither equals {magicNumber}");
            Console.WriteLine($"{combinationNum} combinations - neither equals {magicNumber}");
         }
      }
   }
}
