using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Change_List
{
   class Program
   {
      static void Main(string[] args)
      {
         List<int> numbers = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToList();

         string cmd = Console.ReadLine();

         while (cmd != "end")
         {
            string firstArg = cmd.Split()[0];

            if (firstArg == "Delete")
            {
               int element = int.Parse(cmd.Split()[1]);
               numbers.RemoveAll(x => x == element);
            }
            else if (firstArg == "Insert")
            {
               int element = int.Parse(cmd.Split()[1]);
               int position = int.Parse(cmd.Split()[2]);

               numbers.Insert(position, element);
            }
            cmd = Console.ReadLine();
         }
         Console.WriteLine(string.Join(" ", numbers));
      }
   }
}
