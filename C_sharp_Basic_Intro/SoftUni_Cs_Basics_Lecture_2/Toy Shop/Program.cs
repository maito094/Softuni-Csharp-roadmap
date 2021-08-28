using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const double pricePuzzles = 2.6;
            const double priceTalkingDolls = 3;
            const double priceTeddyBears = 4.1;
            const double priceMinions = 8.2;
            const double priceTrucks = 2;

            double priceExcursion = double.Parse(Console.ReadLine());
            int numPuzzles = int.Parse(Console.ReadLine());
            int numTalkingDolls = int.Parse(Console.ReadLine());
            int numTeddyBears = int.Parse(Console.ReadLine());
            int numMinions = int.Parse(Console.ReadLine());
            int numTrucks = int.Parse(Console.ReadLine());


            bool isDiscountApply;
            if (numMinions + numPuzzles + numTalkingDolls + numTeddyBears + numTrucks >= 50) // !!!!!! allways try if equall to IT!!!!!
            {
                isDiscountApply = true;
            }
            else
            {
                isDiscountApply = false;  
            }

            double moneyGain = (numMinions * priceMinions + numPuzzles * pricePuzzles + numTalkingDolls * priceTalkingDolls + numTeddyBears * priceTeddyBears + numTrucks * priceTrucks);
            if (isDiscountApply)
            {
                moneyGain = moneyGain - (1.0 * moneyGain  * 25 / 100.0);
            }
                      

            double moneyRent = 1.0 * moneyGain * 10 / 100.0;
            moneyGain = moneyGain - moneyRent;
            moneyGain = moneyGain - priceExcursion;

            bool isMoneySufficient = moneyGain >= 0;    // !!!!!! allways try if equall to IT!!!!!
            if (isMoneySufficient)
            {
                Console.WriteLine($"Yes! {Math.Abs(moneyGain):0.00} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(moneyGain):0.00} lv needed.");
            }
        }
    }
}
