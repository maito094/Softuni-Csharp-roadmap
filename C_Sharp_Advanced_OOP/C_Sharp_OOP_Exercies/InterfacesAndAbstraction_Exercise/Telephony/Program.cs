using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
         string[] URLs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

         List<ICallable> callables = new List<ICallable>();
         List<IBrowseable> browseables = new List<IBrowseable>();


         foreach (var item in phoneNumbers)
         {
            ICallable phone = null;

            if (item.All(char.IsDigit))
            {

               if (item.Length == 7)
               {
                  phone = new StationaryPhone(item);

               }
               else if (item.Length == 10)
               {

                  phone = new Smartphone(item);
               }

            }

            callables.Add(phone);

         }

         foreach (var item in URLs)
         {
            IBrowseable browseable = null;

            if (item.Any(char.IsDigit))
            {

            }
            else
            {
               browseable = new Smartphone("0", item);
            }

            browseables.Add(browseable);

         }



         foreach (var item in callables)
         {
            if (item is null)
            {
               Console.WriteLine("Invalid number!");
            }
            else
            {
               item.Call();
            }
         }

         foreach (var item in browseables)
         {
            if (item is null)
            {
               Console.WriteLine("Invalid URL!");
            }
            else
            {
               item.Browse();
            }

         }
      }
   }
}
