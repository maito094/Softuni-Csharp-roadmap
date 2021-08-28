using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetMovie = double.Parse(Console.ReadLine());
            int countStatists = int.Parse(Console.ReadLine());
            double priceClothing = double.Parse(Console.ReadLine());
            double discountClothing = 0;

            double priceDecorMovie = budgetMovie * 0.1;

            if (countStatists > 150)
            {
                discountClothing = priceClothing * 0.1;
            }
            else
            {
                discountClothing = 0;
            }


            if (countStatists*(priceClothing-discountClothing)+priceDecorMovie>budgetMovie)
            {
                double priceInsufficient = (countStatists*(priceClothing - discountClothing) + priceDecorMovie) - budgetMovie;
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {priceInsufficient:0.00} leva more.");
            }
            else if (countStatists*(priceClothing - discountClothing) + priceDecorMovie <= budgetMovie)
            {
                double priceSufficient = budgetMovie - (countStatists*(priceClothing - discountClothing) + priceDecorMovie);
             Console.WriteLine("Action!");
             Console.WriteLine($"Wingard starts filming with {priceSufficient:0.00} leva left.");
            }
        }
    }
}
