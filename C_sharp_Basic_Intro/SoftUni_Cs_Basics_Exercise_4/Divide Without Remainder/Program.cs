using System;

namespace Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;


            for (int i = 1; i <= n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    p1 += 1;
                }
                if (number % 3 == 0)
                {
                    p2 += 1;
                }
                if (number % 4 == 0)
                {
                    p3 += 1;
                }

            }
            Console.WriteLine($"{p1 * 1.00 / n * 100:0.00}%");
            Console.WriteLine($"{p2 * 1.00 / n * 100:0.00}%");
            Console.WriteLine($"{p3 * 1.00 / n * 100:0.00}%");

        }
    }
}
