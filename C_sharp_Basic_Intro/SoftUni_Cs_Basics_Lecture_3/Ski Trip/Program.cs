using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysAt = int.Parse(Console.ReadLine()) - 1;
            string typeOfRoom = Console.ReadLine();
            string reviewGrade = Console.ReadLine();
            double discount = 0;
            double pricePerNight = 0;
            double total = 0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    pricePerNight = 18;

                    break;
                case "apartment":
                    pricePerNight = 25;

                    if (daysAt < 10)
                    {
                        discount = 0.3;
                    }
                    else if (daysAt >= 10 && daysAt <= 15)
                    {
                        discount = 0.35;
                    }
                    else if (daysAt > 15)
                    {
                        discount = 0.5;
                    }
                    break;
                case "president apartment":
                    pricePerNight = 35;

                    if (daysAt < 10)
                    {
                        discount = 0.1;
                    }
                    else if (daysAt >= 10 && daysAt <= 15)
                    {
                        discount = 0.15;
                    }
                    else if (daysAt > 15)
                    {
                        discount = 0.2;
                    }
                    break;

                default:
                    break;
            }

            total = daysAt * pricePerNight * (1 - discount);

            if (reviewGrade == "positive")
            {

                total *= 1.25;
            }
            else
            {
                total *= 0.9;
            }

            Console.WriteLine("{0:F2}",total);
        }
    }
}
