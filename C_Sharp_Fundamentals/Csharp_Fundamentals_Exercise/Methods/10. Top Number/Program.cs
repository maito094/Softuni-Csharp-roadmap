using System;

namespace _10._Top_Number
{
   class Program
   {
      static void Main(string[] args)
      {
         //rule 1 sum of all its digis is divisible by 8
         //rule 2 atleast 1 odd digit

         int n = int.Parse(Console.ReadLine());

         for (int i = 1; i <= n; i++)
         {
            GetMasterNumber(i);
         }
      }

      private static void GetMasterNumber(int n)
      {
         bool isSumDivisibleBy8 = false;
         bool isOneOddDigit = false;

         int num = n;
         int sumDigits = 0;
         int digit = 0;
         while (num > 0)
         {

            digit = num % 10;
            sumDigits += digit;
            num /= 10;

            if (digit % 2 != 0 && isOneOddDigit != true)
            {
               isOneOddDigit = true;
            }

         }

         if (sumDigits % 8 == 0)
         {
            isSumDivisibleBy8 = true;
         }

         if (isSumDivisibleBy8 && isOneOddDigit)
         {
            Console.WriteLine(n);
         }
      }
   }
}
