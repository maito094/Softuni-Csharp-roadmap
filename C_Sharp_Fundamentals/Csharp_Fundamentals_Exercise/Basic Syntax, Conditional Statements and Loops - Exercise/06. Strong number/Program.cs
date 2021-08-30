using System;

namespace _06._Strong_number
{
   class Program
   {
      static void Main(string[] args)
      {
         // Factoriel of each digit is equal to the number == strong number

         int strongNumber = int.Parse(Console.ReadLine());
         int factoriel = 1;
         int currNum = strongNumber;
         int sum = 0;
         while (currNum > 0)
         {
            for (int i = 1; i <= currNum % 10; i++)
            {
               factoriel *= i;
            }
            sum += factoriel;
            factoriel = 1;
            currNum = currNum / 10;
         }
         if (sum == strongNumber)
         {
            Console.WriteLine("yes");
         }
         else
         {
            Console.WriteLine("no");
         }
      }
   }
}
