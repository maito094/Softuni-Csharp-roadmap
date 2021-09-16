using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
   class Program
   {
      static void Main(string[] args)
      {

         Stack<int> stackNumbers = new Stack<int>(Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray());

         string[] cmd = Console.ReadLine().ToLower().Split(" ");

         while (cmd[0] != "end")
         {
            if (cmd[0] == "add")
            {

               for (int i = 1; i < cmd.Length; i++)
               {
                  stackNumbers.Push(int.Parse(cmd[i]));

               }

            }

            if (cmd[0] == "remove" && int.Parse(cmd[1]) <= stackNumbers.Count)
            {
               int cntRemove = int.Parse(cmd[1]);

               while (cntRemove > 0 && stackNumbers.Count > 0)
               {

                  stackNumbers.Pop();
                  cntRemove--;
               }

            }

            cmd = Console.ReadLine().ToLower().Split(" ");
         }

         int sum = 0;

         while (stackNumbers.Count > 0)
         {
            sum += stackNumbers.Pop();
         }
         Console.WriteLine($"Sum: {sum}");
      }
   }
}
