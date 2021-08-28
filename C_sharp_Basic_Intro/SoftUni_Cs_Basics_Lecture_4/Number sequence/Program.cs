using System;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int numMax = int.MaxValue;
            int numMin = int.MinValue;
            int num = 0;


            for (int i = 0; i < n; i++)
            {


                num = int.Parse(Console.ReadLine());
                if (num > numMin)
                {
                    numMin = num;
                }
                if (num < numMax)
                {
                    numMax = num;
                }

            }

            Console.WriteLine($"Max number: {numMin}");
            Console.WriteLine($"Min number: {numMax}");

        }
    }
}
