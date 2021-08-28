using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceCakes = 45;
            double priceWaffers = 5.80;
            double pricePancakes = 3.2;

            int daysCharity = int.Parse(Console.ReadLine());
            int numBakers = int.Parse(Console.ReadLine());
            int numCakes = int.Parse(Console.ReadLine());
            int numWaffers = int.Parse(Console.ReadLine());
            int numPancakes = int.Parse(Console.ReadLine());

            double sumCharity = daysCharity * (numBakers * (numCakes * priceCakes + numWaffers * priceWaffers + numPancakes * pricePancakes));
            sumCharity = sumCharity - sumCharity / 8;
            Console.WriteLine(sumCharity);
        }
    }
}
