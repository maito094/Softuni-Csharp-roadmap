using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberry = double.Parse(Console.ReadLine());
            double quantityBananas = double.Parse(Console.ReadLine());
            double quantityOranges = double.Parse(Console.ReadLine());
            double quantityRaspberries = double.Parse(Console.ReadLine());
            double quantityStrawberries = double.Parse(Console.ReadLine());

            double priceRaspberries = priceStrawberry/2;
            double priceOranges = priceRaspberries - priceRaspberries*40/100;
            double priceBananas = priceRaspberries - priceRaspberries*80/100;

            double sumFinal = quantityStrawberries * priceStrawberry + quantityBananas * priceBananas + quantityOranges * priceOranges + quantityRaspberries * priceRaspberries;

            Console.WriteLine(string.Format("{0:0.00}",sumFinal));
        }
    }
}
