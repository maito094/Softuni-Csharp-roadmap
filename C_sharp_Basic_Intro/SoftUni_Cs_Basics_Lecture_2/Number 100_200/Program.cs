using System;

namespace Number_100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int numUser = int.Parse(Console.ReadLine());
            bool isInBetween100_200 = numUser <= 200 && numUser >= 100;
            bool isBelow100 = numUser < 100;

            if (isInBetween100_200)
            {
                Console.WriteLine("Between 100 and 200");

            }
            if (isBelow100)
            {
                Console.WriteLine("Less than 100");
            }
            if (!isInBetween100_200 && !isBelow100)
            {
                Console.WriteLine("Greater than 200");
            }

        }
    }
}
