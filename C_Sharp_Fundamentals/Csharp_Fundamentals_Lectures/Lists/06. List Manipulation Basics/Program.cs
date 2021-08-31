using System;
using System.Collections.Generic;
using System.Linq;


namespace _06.List_Manipulation_Basics
{
   class Program
   {
      static void Main(string[] args)
      {
         List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

         string cmd = Console.ReadLine();
         while (cmd != "end")
         {

            ListOperation(cmd, ref numbers);
            cmd = Console.ReadLine();
         }

         Console.WriteLine(string.Join(" ", numbers));
      }

      //Add {number}: add a number to the end of the list.
      //Remove {number}: remove a number from the list.
      //RemoveAt {index}: remove a number at a given index.
      //Insert {number} { index}: insert a number at a given index.
      static void ListOperation(string cmd, ref List<int> numList)
      {
         string firstArg = cmd.Split()[0];
         string secondArg = cmd.Split()[1];


         switch (firstArg)
         {
            case "Add":

               numList.Add(int.Parse(secondArg));
               break;
            case "Remove":
               numList.Remove(int.Parse(secondArg));
               break;
            case "RemoveAt":
               numList.RemoveAt(int.Parse(secondArg));
               break;
            case "Insert":
               string thirdArg = cmd.Split()[2];
               numList.Insert(int.Parse(thirdArg), int.Parse(secondArg));
               break;

            default:
               break;
         }
      }

   }
}
