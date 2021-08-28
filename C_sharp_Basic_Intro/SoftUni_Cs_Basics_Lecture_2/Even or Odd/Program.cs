using System;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
           int numUser = int.Parse( Console.ReadLine());
            bool isEven = numUser % 2 == 0;
            if (isEven)
            {
                Console.WriteLine("even");

            }
            else
            {
                Console.WriteLine("odd");

            }
        }
    }
}
