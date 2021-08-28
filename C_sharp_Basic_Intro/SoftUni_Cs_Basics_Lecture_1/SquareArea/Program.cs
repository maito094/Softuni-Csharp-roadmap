using System;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //int.Parse();
            int side = Convert.ToInt32(Console.ReadLine());
            int area = side* side;
            Console.WriteLine(area);
        }
    }
}
