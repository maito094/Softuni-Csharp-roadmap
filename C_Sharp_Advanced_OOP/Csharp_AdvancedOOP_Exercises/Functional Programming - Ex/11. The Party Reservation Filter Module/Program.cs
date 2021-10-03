using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
   class Program
   {
      static void Main(string[] args)
      {
         List<string> names = Console.ReadLine().Split(" ").ToList();
         var dictionary = new Dictionary<string, Predicate<string>>();

         while (true)
         {
            string[] cmdInfo = Console.ReadLine().Split(";");
            string action = cmdInfo[0];
            if (action == "Print")
            {
               break;
            }
            string predicateAction = cmdInfo[1];
            string value = cmdInfo[2];

            string key = predicateAction + "_" + value;

            if (action == "Add filter")
            {
               Predicate<string> predicate = GetPredicate(predicateAction, value);
               dictionary.Add(key, predicate);
            }
            else
            {
               dictionary.Remove(key);
            }

         }

         foreach (var (key, predicate) in dictionary)
         {
            names.RemoveAll(predicate);
         }

         Console.WriteLine(string.Join(" ", names));
      }
      private static Predicate<string> GetPredicate(string subCMD, string subCMDArgument)
      {
         if (subCMD == "Starts with")
         {
            return x => x.StartsWith(subCMDArgument);
         }
         if (subCMD == "Ends with")
         {
            return x => x.EndsWith(subCMDArgument);
         }
         if (subCMD == "Contains")
         {
            return x => x.Contains(subCMDArgument);
         }

         int length = int.Parse(subCMDArgument);

         return x => x.Length == length;
      }
   }
}
