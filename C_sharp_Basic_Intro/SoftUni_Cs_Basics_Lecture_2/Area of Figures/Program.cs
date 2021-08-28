using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            // (square, rectangle, circle или triangle).

            string userShape = Console.ReadLine();
            double area = 0;

            switch (userShape)
            {
                case "square":
                    double sideA = double.Parse(Console.ReadLine());
                    area = sideA * sideA;
                    break;
                case "rectangle":
                    sideA = double.Parse(Console.ReadLine());
                    double sideB = double.Parse(Console.ReadLine());

                    area = sideA * sideB;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI*radius*radius;
                    break;
                case "triangle":
                    sideA = double.Parse(Console.ReadLine());
                    sideB = double.Parse(Console.ReadLine());
                    area = sideA * sideB / 2;
                    break;

                default:
                    break;
            }
            Console.WriteLine(Math.Round(area,3));
        }
    }
}
