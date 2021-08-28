using System;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double minOddNumber = double.MaxValue;
            double maxOddNumber = double.MinValue;

            double minEvenNumber = double.MaxValue;
            double maxEvenNumber = double.MinValue;

            double number = 0;

            double sumOdd = 0;
            double sumEven = 0;

            for (int i = 1; i <= n; i++)
            {
                number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += number;
                    if (number > maxEvenNumber)
                    {
                        maxEvenNumber = number;
                    }
                    if (number < minEvenNumber)
                    {
                        minEvenNumber = number;
                    }
                }
                else
                {
                    sumOdd += number;
                    if (number > maxOddNumber)
                    {
                        maxOddNumber = number;
                    }
                    if (number < minOddNumber)
                    {
                        minOddNumber = number;
                    }
                }
            }
            Console.WriteLine($"OddSum={sumOdd:0.00},");

            if (sumOdd != 0)
            {
                Console.WriteLine($"OddMin={minOddNumber:0.00},");
                Console.WriteLine($"OddMax={maxOddNumber:0.00},");
            }
            else
            {
                Console.WriteLine($"OddMin=" + "No,");
                Console.WriteLine($"OddMax=" + "No,");
            }


            Console.WriteLine($"EvenSum={sumEven:0.00},");

            if (sumEven != 0)
            {
                Console.WriteLine($"EvenMin={minEvenNumber:0.00},");
                Console.WriteLine($"EvenMax={maxEvenNumber:0.00}");
            }
            else
            {
                Console.WriteLine($"EvenMin=" + "No,");
                Console.WriteLine($"EvenMax=" + "No");
            }

        }
    }
}
