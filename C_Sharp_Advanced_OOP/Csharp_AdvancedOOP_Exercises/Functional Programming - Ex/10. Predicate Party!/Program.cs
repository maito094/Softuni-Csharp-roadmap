using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
   class Program
   {
      static void Main(string[] args)
      {
         List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

         while (true)
         {
            string[] cmdInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string cmd = cmdInfo[0]; //Party! / Remove, Double

            if (cmd == "Party!")
            {
               break;
            }

            string subCMD = cmdInfo[1];  //StartsWith, EndsWith, Length
            string subCMDArgument = cmdInfo[2];

            Predicate<string> predicate = GetPredicate(subCMD, subCMDArgument);

            if (cmd == "Remove")
            {
               names.RemoveAll(predicate);
            }
            else if (cmd == "Double")
            {

               List<string> doubleNames = names.FindAll(predicate);

               if (doubleNames.Any())
               {
                  int index = names.FindIndex(predicate);
                  names.InsertRange(index, doubleNames);
               }

            }

         }

         if (names.Any())
         {
            Console.WriteLine(string.Join(", ", names) + " are going to the party!");
         }
         else
         {
            Console.WriteLine("Nobody is going to the party!");
         }
      }

      private static Predicate<string> GetPredicate(string subCMD, string subCMDArgument)
      {
         if (subCMD == "StartsWith")
         {
            return x => x.StartsWith(subCMDArgument);
         }
         if (subCMD == "EndsWith")
         {
            return x => x.EndsWith(subCMDArgument);
         }

         int length = int.Parse(subCMDArgument);

         return x => x.Length == length;
      }
   }
}
