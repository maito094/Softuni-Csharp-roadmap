using System;

namespace Excellent
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            bool isExcellent = grade >= 5.5;
            if (isExcellent)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
