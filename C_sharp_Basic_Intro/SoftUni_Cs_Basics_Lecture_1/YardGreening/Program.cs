using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerSqrMeter = 7.61;
            double percentDiscount = 18; // in %;
            double numSqrMeters = double.Parse(Console.ReadLine());
            double priceDiscounted = (numSqrMeters * pricePerSqrMeter) * percentDiscount / 100;
            double priceFinal = (numSqrMeters * pricePerSqrMeter) - priceDiscounted;
            Console.WriteLine($"The final price is: {priceFinal} lv.");
            Console.WriteLine($"The discount is {priceDiscounted} lv.");
        }
    }
}
