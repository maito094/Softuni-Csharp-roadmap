using System;

namespace Trekking_Mania
{
   class Program
   {
      static void Main(string[] args)
      {
         double percentMusala = 0;
         double percentMonblanc = 0;
         double percentKilimanjaro = 0;
         double percentK2 = 0;
         double percentEverest = 0;
         int numGroups = int.Parse(Console.ReadLine());
         int[] numPeoplePerGroup = new int[numGroups];
         int allnumPeople = 0;
         for (int i = 0; i < numGroups; i++)
         {
            numPeoplePerGroup[i] = int.Parse(Console.ReadLine());
            allnumPeople += numPeoplePerGroup[i];
            if (numPeoplePerGroup[i] <= 5)
            {
               percentMusala += numPeoplePerGroup[i];
            }
            else if (numPeoplePerGroup[i] >= 6 && numPeoplePerGroup[i] <= 12)
            {
               percentMonblanc += numPeoplePerGroup[i];
            }
            else if (numPeoplePerGroup[i] >= 13 && numPeoplePerGroup[i] <= 25)
            {
               percentKilimanjaro += numPeoplePerGroup[i];
            }
            else if (numPeoplePerGroup[i] >= 26 && numPeoplePerGroup[i] <= 40)
            {
               percentK2 += numPeoplePerGroup[i];
            }
            else if (numPeoplePerGroup[i] >= 41)
            {
               percentEverest += numPeoplePerGroup[i];
            }
         }

         percentMusala = percentMusala * 100.00 / allnumPeople;
         percentMonblanc = percentMonblanc * 100.00 / allnumPeople;
         percentKilimanjaro = percentKilimanjaro * 100.00 / allnumPeople;
         percentK2 = percentK2 * 100.00 / allnumPeople;
         percentEverest = percentEverest * 100.00 / allnumPeople;



         Console.WriteLine($"{percentMusala:f2}%");
         Console.WriteLine($"{percentMonblanc:f2}%");
         Console.WriteLine($"{percentKilimanjaro:f2}%");
         Console.WriteLine($"{percentK2:f2}%");
         Console.WriteLine($"{percentEverest:f2}%");
      }
   }
}
