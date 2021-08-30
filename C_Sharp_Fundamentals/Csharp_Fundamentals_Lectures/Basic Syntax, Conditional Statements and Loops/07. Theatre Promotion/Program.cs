using System;

namespace _07._Theatre_Promotion
{
   class Program
   {
      static void Main(string[] args)
      {
         string typeDay = Console.ReadLine();
         int age = int.Parse(Console.ReadLine());
         int priceTicket = 0;
         if (typeDay == "Weekday" && ((age >= 0 && age <= 18) || (age > 64 && age <= 122)) || (typeDay == "Holiday" && (age > 18 && age <= 64)))
         {
            priceTicket = 12;
         }
         else if (typeDay == "Weekday" && (age > 18 && age <= 64))
         {
            priceTicket = 18;
         }
         if (typeDay == "Weekend" && ((age >= 0 && age <= 18) || (age > 64 && age <= 122)))
         {
            priceTicket = 15;
         }
         else if (typeDay == "Weekend" && (age > 18 && age <= 64))
         {
            priceTicket = 20;
         }
         if (typeDay == "Holiday" && (age >= 0 && age <= 18))
         {
            priceTicket = 5;
         }
         else if (typeDay == "Holiday" && (age > 64 && age <= 122))
         {
            priceTicket = 10;
         }

         if (priceTicket == 0)
         {
            Console.WriteLine("Error!");
         }
         else
         {
            Console.WriteLine($"{priceTicket}$");
         }
      }
   }
}
