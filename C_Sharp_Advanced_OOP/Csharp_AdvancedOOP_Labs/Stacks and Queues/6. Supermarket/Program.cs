using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
   class Program
   {
      static void Main(string[] args)
      {
         string input = string.Empty;
         Queue<string> names = new Queue<string>();

         while (true)
         {
            input = Console.ReadLine();
            if (input == "End")
            {
               break;
            }
            else if (input == "Paid")
            {
               while (names.Count > 0)
               {
                  Console.WriteLine(names.Dequeue());
               }
               continue;
            }
            names.Enqueue(input);
         }
         Console.WriteLine($"{names.Count} people remaining.");
      }
   }
}
