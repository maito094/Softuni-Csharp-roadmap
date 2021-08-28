using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            int number = 0;
            int sum = 0;

            for (int i = 0; i <= n - 1; i++)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
            if ((sum - maxNumber) == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxNumber);

            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sum - maxNumber * 2));
            }
        }
    }
}
