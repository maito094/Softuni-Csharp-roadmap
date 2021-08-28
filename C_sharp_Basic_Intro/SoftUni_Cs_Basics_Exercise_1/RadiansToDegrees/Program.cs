using System;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = float.Parse(Console.ReadLine());
            double deg = Math.Round(rad * 180 / Math.PI);
            Console.WriteLine(string.Format("{0}",deg));
        }
    }
}
