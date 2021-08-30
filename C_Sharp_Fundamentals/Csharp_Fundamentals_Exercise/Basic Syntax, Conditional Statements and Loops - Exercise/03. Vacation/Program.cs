using System;

namespace _03._Vacation
{
   class Program
   {
      static void Main(string[] args)
      {
         int people = int.Parse(Console.ReadLine());
         string typeGroup = Console.ReadLine();
         string dayOfWeek = Console.ReadLine();
         double pricePerGroup = 0;
         double totalPrice = 0;

         if (typeGroup == "Students")
         {

            pricePerGroup = Convert.ToInt32(dayOfWeek == "Friday") * 8.45 +
                            Convert.ToInt32(dayOfWeek == "Saturday") * 9.80 +
                            Convert.ToInt32(dayOfWeek == "Sunday") * 10.46;

            totalPrice = (people * pricePerGroup) - (Convert.ToInt32(people >= 30) * (people * pricePerGroup) * 0.15);

         }
         else if (typeGroup == "Business")
         {
            pricePerGroup = Convert.ToInt32(dayOfWeek == "Friday") * 10.90 +
                            Convert.ToInt32(dayOfWeek == "Saturday") * 15.60 +
                            Convert.ToInt32(dayOfWeek == "Sunday") * 16;

            totalPrice = ((people - Convert.ToInt32(people >= 100) * 10) * pricePerGroup);

         }
         else if (typeGroup == "Regular")
         {

            pricePerGroup = Convert.ToInt32(dayOfWeek == "Friday") * 15 +
                            Convert.ToInt32(dayOfWeek == "Saturday") * 20 +
                            Convert.ToInt32(dayOfWeek == "Sunday") * 22.50;

            totalPrice = (people * pricePerGroup) - (Convert.ToInt32(people >= 10 && people <= 20) * (people * pricePerGroup) * 0.05);

         }


         Console.WriteLine($"Total price: {totalPrice:F2}");
      }
   }
}
