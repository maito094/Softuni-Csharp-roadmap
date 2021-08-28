using System;

namespace Fitness_Card
{
   class Program
   {
      static void Main(string[] args)
      {
         double sumAvailable = double.Parse(Console.ReadLine());
         char sex = char.Parse(Console.ReadLine()); //'m' or 'f'
         int age = int.Parse(Console.ReadLine());
         string sport = Console.ReadLine();// "Gym","Boxing","Yoga","Zumba","Dances","Pilates"

         double pricePerMember = 0;

         switch (sport)
         {
         case "Gym":
            if (sex == 'm')
            {
               pricePerMember = 42;//$$
            }
            else
            {
               pricePerMember = 35;
            }
            break;
         case "Boxing":
            if (sex == 'm')
            {
               pricePerMember = 41;//$$
            }
            else
            {
               pricePerMember = 37;
            }
            break;
         case "Yoga":
            if (sex == 'm')
            {
               pricePerMember = 45;//$$
            }
            else
            {
               pricePerMember = 42;
            }
            break;
         case "Zumba":
            if (sex == 'm')
            {
               pricePerMember = 34;//$$
            }
            else
            {
               pricePerMember = 31;
            }
            break;
         case "Dances":
            if (sex == 'm')
            {
               pricePerMember = 51;//$$
            }
            else
            {
               pricePerMember = 53;
            }
            break;
         case "Pilates":
            if (sex == 'm')
            {
               pricePerMember = 39;//$$
            }
            else
            {
               pricePerMember = 27;
            }
            break;
         }

         if (age <= 19)
         {
            pricePerMember -= pricePerMember * 1.0 / 5;
         }
         if (sumAvailable >= pricePerMember)
         {
            Console.WriteLine($"You purchased a 1 month pass for {sport}.");

         }
         else
         {

            Console.WriteLine($"You don't have enough money! You need ${(pricePerMember - sumAvailable):f2} more.");
         }
      }
   }
}
