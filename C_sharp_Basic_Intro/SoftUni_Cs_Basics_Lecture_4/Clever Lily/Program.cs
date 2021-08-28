using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBirthdays = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            double priceToys = double.Parse(Console.ReadLine());
            int numToys = 0;
            double sumEvenB = 0;
            for (int i = 1; i <= numBirthdays; i++)
            {
                if (i % 2 == 0)
                {
                    sumEvenB += (10 * i / 2) - 1;
                }
                else
                {
                    numToys++;
                }
            }
            sumEvenB = (sumEvenB + numToys * priceToys) - priceWashingMachine;
            if (sumEvenB >= 0)
            {

                Console.WriteLine($"Yes! { sumEvenB:F2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(sumEvenB):F2}");
            }
        }
    }
}
