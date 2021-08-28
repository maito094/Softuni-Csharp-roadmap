using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string accommodation = "";
            
            double priceDestination = 0;

            switch (season)
            {
                case "summer":
                    if (budget<=100)
                    {
                        destination = "Bulgaria";
                        accommodation = "Camp";
                        priceDestination = budget * 0.3;
                    }
                    else if (budget>100 && budget<=1000)
                    {
                        destination = "Balkans";
                        accommodation = "Camp";
                        priceDestination = budget * 0.4;
                    }
                 
                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        destination = "Bulgaria";
                        accommodation = "Hotel";
                        priceDestination = budget * 0.7;
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        destination = "Balkans";
                        accommodation = "Hotel";
                        priceDestination = budget * 0.8;
                    }
                    break;
                default:

                    break;
            }

            if (budget > 1000)
            {
                destination = "Europe";
                accommodation = "Hotel";
                priceDestination = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}" );
            Console.WriteLine($"{accommodation} - {Math.Round(priceDestination,2):0.00}");
        }
    }
}
