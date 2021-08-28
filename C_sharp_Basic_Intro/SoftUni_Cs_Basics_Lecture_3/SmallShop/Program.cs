using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double priceSum = 0;

            if (city=="Sofia")
            {

                if (product=="coffee")
                {
                    priceSum = 0.5 * quantity;
                }
                else if (product=="water")
                {
                    priceSum = 0.8 * quantity;
                }
                else if (product=="beer")
                {
                    priceSum = 1.2 * quantity;
                }
                else if (product=="sweets")
                {
                    priceSum = 1.45 * quantity;
                }
                else if (product=="peanuts")
                {
                    priceSum = 1.6 * quantity;
                }
            }



            else if (city=="Plovdiv")
            {

                if (product == "coffee")
                {
                    priceSum = 0.4 * quantity;
                }
                else if (product == "water")
                {
                    priceSum = 0.7 * quantity;
                }
                else if (product == "beer")
                {
                    priceSum = 1.15 * quantity;
                }
                else if (product == "sweets")
                {
                    priceSum = 1.30 * quantity;
                }
                else if (product == "peanuts")
                {
                    priceSum = 1.5 * quantity;
                }
            }
            else if (city=="Varna")
            {

                if (product == "coffee")
                {
                    priceSum = 0.45 * quantity;
                }
                else if (product == "water")
                {
                    priceSum = 0.7 * quantity;
                }
                else if (product == "beer")
                {
                    priceSum = 1.10 * quantity;
                }
                else if (product == "sweets")
                {
                    priceSum = 1.35 * quantity;
                }
                else if (product == "peanuts")
                {
                    priceSum = 1.55 * quantity;
                }
            }
           
            Console.WriteLine(priceSum);
        }
    }
}
