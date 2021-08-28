using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            float rent = float.Parse(Console.ReadLine());
            float priceCake = rent * 20 / 100;
            float priceBeverages = priceCake - priceCake * 45 / 100;
            float priceAnimator = rent / 3;
            float sumParty = rent + priceCake + priceBeverages + priceAnimator;
            Console.WriteLine(sumParty);
        }
    }
}
