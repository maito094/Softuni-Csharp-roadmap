using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += number;

                }
                else
                {
                    sumOdd += number;
                }
            }

            if (sumEven == sumOdd)
            {
                result = sumEven;
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + result);

            }
            else
            {
                result = Math.Abs(sumEven - sumOdd);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + result);
            }


        }
    }
}
