using System;

namespace Histogram
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
            double p4 = 0;
            double p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1 += 1;
                }
                else if (number >= 200 && number <= 399)
                {
                    p2 += 1;
                }
                else if (number >= 400 && number <= 599)
                {
                    p3 += 1;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4 += 1;
                }
                else if (number >= 800)
                {
                    p5 += 1;
                }
            }
            Console.WriteLine($"{p1*1.00/n*100:0.00}%");
            Console.WriteLine($"{p2*1.00/n*100:0.00}%");
            Console.WriteLine($"{p3*1.00/n*100:0.00}%");
            Console.WriteLine($"{p4*1.00/n*100:0.00}%");
            Console.WriteLine($"{p5*1.00/n*100:0.00}%");
        }
    }
}
