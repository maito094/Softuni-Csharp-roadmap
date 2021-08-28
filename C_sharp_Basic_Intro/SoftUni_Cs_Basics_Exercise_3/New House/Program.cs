using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlower = Console.ReadLine();
            int numFlower = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double pricePerFlower = 0;
            double discount = 0;
            double total = 0;
            switch (typeOfFlower)
            {
                case "Roses":
                    pricePerFlower = 5;
                    if (numFlower>80)
                    {
                        discount = 0.1;
                    }
                    break;
                case "Dahlias":
                    pricePerFlower = 3.80;
                    if (numFlower > 90)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Tulips":
                    pricePerFlower = 2.8;
                    if (numFlower > 80)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Narcissus":
                    pricePerFlower = 3;
                    if (numFlower < 120)
                    {
                        discount = -0.15;
                    }
                    break;
                case "Gladiolus":
                    pricePerFlower = 2.5;
                    if (numFlower < 80)
                    {
                        discount = -0.20;
                    }
                    break;

                default:
                    break;
            }

            total = numFlower * pricePerFlower * (1 - discount);

            if (budget>= total)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlower} {typeOfFlower} and {(budget-total):0.00} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget - total):0.00} leva more.");

            }

        }
    }
}
