using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = float.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}
