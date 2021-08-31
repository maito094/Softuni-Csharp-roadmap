using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Train
{
   class Program
   {
      static void Main(string[] args)
      {
         List<int> numPassengers = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToList();

         int maxCapacity = int.Parse(Console.ReadLine());
         string cmd = Console.ReadLine();

         while (cmd != "end")
         {
            string firstArg = cmd.Split()[0];
            int secondArg = 0;

            if (firstArg.Contains("Add"))
            {
               secondArg = int.Parse(cmd.Split()[1]);
               numPassengers.Add(secondArg);
            }
            else
            {
               for (int i = 0; i < numPassengers.Count; i++)
               {

                  secondArg = int.Parse(cmd);
                  if (numPassengers[i] + secondArg <= maxCapacity)
                  {
                     numPassengers[i] += secondArg;
                     break;
                  }

               }

            }
            cmd = Console.ReadLine();
         }
         Console.WriteLine(string.Join(" ", numPassengers));
      }
   }
}
