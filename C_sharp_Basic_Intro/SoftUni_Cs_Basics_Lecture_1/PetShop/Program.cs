using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceFoodDogs = 2.5;
            double priceFoodAnimals = 4;
            int numDogs = int.Parse(Console.ReadLine());
           int numOtherAnimals = int.Parse( Console.ReadLine());
            double foodExpenses = numDogs * priceFoodDogs + numOtherAnimals * priceFoodAnimals;
            Console.WriteLine($"{foodExpenses} lv.");
        }
    }
}
