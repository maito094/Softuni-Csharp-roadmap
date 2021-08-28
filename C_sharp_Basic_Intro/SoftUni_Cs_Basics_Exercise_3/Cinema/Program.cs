using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typePojection = Console.ReadLine();
            int rows= int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double priceProjection = 0;
            double income = 0;

            switch (typePojection)
            {
                case "Premiere":
                    priceProjection = 12;
                break;
                case "Normal":
                    priceProjection = 7.5;
                break;
                case "Discount":
                    priceProjection = 5;
                break;

                default:
                break;
            }
            income = rows * columns * priceProjection;
            Console.WriteLine("{0:F2}",income);
        }
    }
}
