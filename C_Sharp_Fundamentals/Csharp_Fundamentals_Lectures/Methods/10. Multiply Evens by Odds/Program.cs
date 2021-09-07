using System;

namespace _10._Multiply_Evens_by_Odds
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = Math.Abs(int.Parse(Console.ReadLine()));

         int multiple = GetMultipleOfEvenAndOdds(n);
         Console.WriteLine(multiple);

      }
      static int GetMultipleOfEvenAndOdds(int n)
      {
         int num = n;
         int sumEven = 0;
         int sumOdd = 0;
         int multiplication = 1;

         while (num > 0)
         {
            int lastdigit = num % 10;
            num /= 10;

            if (lastdigit % 2 == 0)
            {
               sumEven += lastdigit; //GetSumOfEvenDigits(lastdigit);
            }
            else
            {
               sumOdd += lastdigit;//GetSumOfOddDigits(lastdigit);
            }
         }

         multiplication = sumOdd * sumEven;

         return multiplication;
      }
      //static int GetSumOfEvenDigits(int evenDigit)
      //{

      //}
      //static int GetSumOfOddDigits(int oddDigit)
      //{

      //}
   }
}
