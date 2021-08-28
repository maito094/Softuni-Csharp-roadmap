using System;

namespace NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int numChosen = int.Parse(Console.ReadLine());

            if ((numChosen>0 || numChosen<0) && numChosen>=-100 && numChosen<=100)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");

            }

        }
    }
}
