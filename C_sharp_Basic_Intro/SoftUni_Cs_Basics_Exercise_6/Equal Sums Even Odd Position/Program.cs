using System;

namespace Equal_Sums_Even_Odd_Position
{
   class Program
   {
      static void Main(string[] args)
      {
         //100000 до 300000 6-digit number, firstNumber < secondNumber always
         int minNum = int.Parse(Console.ReadLine());
         int maxNum = int.Parse(Console.ReadLine());

         int oddSum = 0;
         int evenSum = 0;

         int currentNumber = 0;
         int lastDigit = 0;

         for (int curNum = minNum; curNum <= maxNum; curNum++)
         {
            oddSum = 0;
            evenSum = 0;
            currentNumber = curNum;
            
            for (int curDigit = curNum.ToString().Length - 1; curDigit >= 0; curDigit--)
            {

               lastDigit = currentNumber % 10;
               currentNumber = currentNumber / 10;

               if (curDigit % 2 == 0)
               {
                  oddSum+=lastDigit;
               }
               else
               {
                  evenSum+=lastDigit;
               }
            }

            if (oddSum == evenSum)
            {
               Console.Write(curNum + " ");

            }

         }
      }
   }
}
