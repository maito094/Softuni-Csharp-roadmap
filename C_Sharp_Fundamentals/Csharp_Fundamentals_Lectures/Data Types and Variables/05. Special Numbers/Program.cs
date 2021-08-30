using System;

namespace _05._Special_Numbers
{
   class Program
   {
      static void Main(string[] args)
      {
         int num = int.Parse(Console.ReadLine());
         for (int i = 1; i <= num; i++)
         {
            int sum = 0;
            int n = i;
            while (n > 0)
            {
               sum += n % 10;
               n = n / 10;
            }

            bool isSpecial = sum == 5 || sum == 7 || sum == 11;
            Console.WriteLine($"{i} -> {isSpecial}");
         }
      }
   }
}
