using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());

         Dictionary<string, IBuyer> people = new Dictionary<string, IBuyer>();

         int totalFoodBough = 0;

         for (int i = 0; i < n; i++)
         {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string person = input[0];
            IBuyer buyer = null;

            if (input.Length == 4)
            {

               buyer = new Citizen(person, int.Parse(input[1]), input[2], input[3]);
            }
            else if (input.Length == 3)
            {


               buyer = new Rebel(person, int.Parse(input[1]), input[2]);
            }

            people.Add(person, buyer);
         }

         while (true)
         {
            string buyerName = Console.ReadLine();
            if (buyerName == "End")
            {
               break;
            }

            if (!people.ContainsKey(buyerName))
            {
               continue;
            }
            else
            {
               people[buyerName].BuyFood();
            }

         }

         Console.WriteLine(people.Sum(x => x.Value.Food));
      }
   }
}
