using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.House_Party
{
   class Program
   {
      static void Main(string[] args)
      {
         //List<int> random = Console.ReadLine()
         //                 .Split()
         //                 .Select(int.Parse)
         //                 .ToList();

         int numPeople = int.Parse(Console.ReadLine());

         List<string> Names = new List<string>();
         for (int i = 0; i < numPeople; i++)
         {
            string cmd = Console.ReadLine();
            string currentName = cmd.Split()[0];
            if (cmd.Contains("not"))
            {

               if (Names.Remove(currentName) != true)
               {
                  Console.WriteLine($"{currentName} is not in the list!");
               }

            }
            else
            {
               if (Names.Contains(currentName))
               {
                  Console.WriteLine($"{currentName} is already in the list!");
               }
               else
               {
                  Names.Add(currentName);
               }
            }
         }
         Console.WriteLine(string.Join("\n", Names));
      }
   }
}
