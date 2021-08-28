using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double exchangeRateUSD = 1.79549;
            double valueUSD = float.Parse(Console.ReadLine());
            double valueBGN = valueUSD * exchangeRateUSD;
            Console.WriteLine(string.Format("{0:0.00}",valueBGN));
        }
    }
}
