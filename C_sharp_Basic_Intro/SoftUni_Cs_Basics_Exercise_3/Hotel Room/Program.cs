using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());
            double priceStudioPerNight = 0;
            double priceApartmentPerNight = 0;
            double totalStudio = 0;
            double totalApartment = 0;

            switch (month)
            {
                case "May":
                case "October":
                     priceStudioPerNight = 50;
                     priceApartmentPerNight = 65;
                    if (numNights>7 && numNights<=14)
                    {
                        priceStudioPerNight *= (1 - 0.05);
                    }
                    else if (numNights > 14)
                    {
                        priceStudioPerNight *= (1 - 0.3);
                    }
                    break;
                case "June":
                case "September":
                     priceStudioPerNight = 75.20;
                     priceApartmentPerNight = 68.70;
                    if (numNights > 14)
                    {
                        priceStudioPerNight *= (1 - 0.2);
                    }
                    break;
                case "July":
                case "August":
                     priceStudioPerNight = 76;
                     priceApartmentPerNight = 77;
                    break;

                default:
                    break;
            }
            if (numNights>14)
            {
                priceApartmentPerNight *= (1 - 0.1);
            }

            totalApartment = numNights * priceApartmentPerNight;
            totalStudio = numNights * priceStudioPerNight;
            Console.WriteLine($"Apartment: {totalApartment:0.00} lv.");
            Console.WriteLine($"Studio: {totalStudio:0.00} lv.");
        }
    }
}
