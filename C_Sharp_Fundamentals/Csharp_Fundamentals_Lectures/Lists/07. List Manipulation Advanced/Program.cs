using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.List_Manipulation_Advanced
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


            ListOperationAdvanced(cmd, ref numbers);
            cmd = Console.ReadLine();
         }

         // Console.WriteLine(string.Join(" ", numbers));
      }


      static void ListOperationAdvanced(string cmd, ref List<int> numList)
      {
         string firstArg = cmd.Split()[0];
         string secondArg = string.Empty;
         int thirdArg = 0;

         switch (firstArg)
         {
            case "Contains":
               secondArg = cmd.Split()[1];
               if (numList.Contains(int.Parse(secondArg)))
               {
                  Console.WriteLine("Yes");
               }
               else
               {
                  Console.WriteLine("No such number");
               }

               break;
            case "PrintEven":
               foreach (var num in numList)
               {
                  if (num % 2 == 0)
                  {
                     Console.Write(num + " ");
                  }
               }
               Console.WriteLine();
               break;
            case "PrintOdd":

               Console.WriteLine(string.Join(" ", numList.FindAll(x => x % 2 != 0)));
               break;
            case "GetSum":

               Console.WriteLine(numList.Sum());
               break;
            case "Filter":
               secondArg = cmd.Split()[1];
               thirdArg = int.Parse(cmd.Split()[2]);
               if (secondArg == "<")
               {
                  Console.WriteLine(string.Join(" ", numList.FindAll(x => x < thirdArg)));
               }
               else if (secondArg == ">")
               {
                  Console.WriteLine(string.Join(" ", numList.FindAll(x => x > thirdArg)));
               }
               else if (secondArg == ">=")
               {
                  Console.WriteLine(string.Join(" ", numList.FindAll(x => x >= thirdArg)));
               }
               else if (secondArg == "<=")
               {
                  Console.WriteLine(string.Join(" ", numList.FindAll(x => x <= thirdArg)));
               }

               break;

            default:
               break;
         }
      }

   }
}
