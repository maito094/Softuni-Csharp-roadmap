using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
   class Program
   {
      static void Main(string[] args)
      {

         HashSet<string> regular = new HashSet<string>();
         HashSet<string> VIP = new HashSet<string>();
         bool isParty = false;
         while (true)
         {
            string inputLines = Console.ReadLine();

            if (inputLines == "END")
            {
               break;
            }

            if (inputLines == "PARTY")
            {
               isParty = true;
            }

            if (!isParty)
            {
               if (char.IsDigit(inputLines[0]))
               {
                  VIP.Add(inputLines);
               }
               else
               {
                  regular.Add(inputLines);
               }
            }
            else
            {
               if (char.IsDigit(inputLines[0]))
               {
                  VIP.Remove(inputLines);
               }
               else
               {
                  regular.Remove(inputLines);
               }
            }

         }

         Console.WriteLine(VIP.Count + regular.Count);
         foreach (var guest in VIP)
         {
            Console.WriteLine(guest);
         }
         foreach (var guest in regular)
         {
            Console.WriteLine(guest);
         }

      }
   }
}
