using System;
using System.Collections.Generic;
using System.Globalization;

namespace BirthdayCelebrations
{
   class Program
   {
      static void Main(string[] args)
      {
         List<IBirthable> birthables = new List<IBirthable>();

         while (true)
         {
            string input = Console.ReadLine();

            if (input == "End")
            {
               break;
            }

            string[] inputInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            IBirthable birthable = null;

            if (inputInfo[0] == "Citizen")
            {
               birthable = new Citizen(
                                        inputInfo[3],
                                        inputInfo[1],
                                        int.Parse(inputInfo[2]),
                                        inputInfo[4]
                                        );


            }
            else if (inputInfo[0] == "Pet")
            {
               birthable = new Pet(
                                     inputInfo[1],
                                     inputInfo[2]
                                     );

            }
            else
            {
               continue;
            }

            birthables.Add(birthable);

         }

         string yearOfBirth = Console.ReadLine();

         foreach (var item in birthables)
         {
            if (item.BirthDate.EndsWith(yearOfBirth))
            {

               Console.WriteLine($"{item.BirthDate}");

            }
         }

      }
   }
}
