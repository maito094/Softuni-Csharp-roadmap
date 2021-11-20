using System;
using System.Collections.Generic;

namespace BorderControl
{
   class Program
   {
      static void Main(string[] args)
      {

         List<IIdentifiable> identifiables = new List<IIdentifiable>();

         while (true)
         {
            string input = Console.ReadLine();

            if (input == "End")
            {
               break;
            }
            IIdentifiable identifiable = null;

            string[] inputInfo = input.Split();
            if (inputInfo.Length == 2)
            {
               //robot
               string model = inputInfo[0];
               string id = inputInfo[1];

               identifiable = new Robot(id, model);
            }
            else if (inputInfo.Length == 3)
            {
               //citizen
               string name = inputInfo[0];
               int age = int.Parse(inputInfo[1]);
               string id = inputInfo[2];

               identifiable = new Citizen(id, name, age);

            }
            identifiables.Add(identifiable);
         }

         string endDigits = Console.ReadLine();

         foreach (var item in identifiables)
         {
            if (item.Id.EndsWith(endDigits))
            {
               Console.WriteLine(item.Id);
            }
         }
      }
   }
}
