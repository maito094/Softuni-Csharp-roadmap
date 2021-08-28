using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numFishermen = int.Parse(Console.ReadLine());
            double discount = 0;
            int priceBoat = 0;

            double total = 0;

            if (numFishermen<=6)
            {
                discount = 0.1;
            }
            else if (numFishermen>=7 && numFishermen<=11)
            {
                discount = 0.15;
            }
            else if (numFishermen>=12)
            {
                discount = 0.25;
            }
           
            switch (season)
            {
                case "Spring":
                    priceBoat = 3000;
                    break;
                case "Winter":
                    priceBoat = 2600;
                    break;
                case "Summer":
                case "Autumn":
                    priceBoat = 4200;
                    break;
                default:
                    break;
            }

            total = priceBoat * (1 - discount);
            if (season != "Autumn" && numFishermen % 2 == 0)
            {
                total *= 0.95;
            }

            if (budget>=total)
            {
                Console.WriteLine($"Yes! You have {(budget-total):0.00} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - total):0.00} leva.");
            }
        }
    }
}
