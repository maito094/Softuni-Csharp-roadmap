using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
   class Program
   {
      static void Main(string[] args)
      {

         Dictionary<string, int> recources = new Dictionary<string, int>();

         string input = Console.ReadLine();
         bool isOdd = true;
         string currentItem = string.Empty;
         while (input != "stop")
         {
            //odd number input = item
            //even number input = recource
            if (isOdd)
            {
               if (!recources.ContainsKey(input))
               {
                  recources.Add(input, 0);
               }
               currentItem = input;
               isOdd = false;
            }
            else
            {
               int value = int.Parse(input);
               isOdd = true;
               recources[currentItem] += value;
            }

            input = Console.ReadLine();

         }

         foreach (var item in recources)
         {
            Console.WriteLine($"{item.Key} -> {item.Value}");
         }
      }
   }
}
