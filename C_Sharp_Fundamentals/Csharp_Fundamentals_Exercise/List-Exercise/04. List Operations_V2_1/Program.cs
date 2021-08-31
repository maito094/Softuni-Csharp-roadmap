using System;
using System.Collections.Generic;
using System.Linq;


namespace _04._List_Operations_V2_1
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
         while (cmd != "End")
         {
            string[] argsCMD = cmd.Split();


            if (argsCMD[0] == "Add")
            {
               int number = int.Parse(argsCMD[1]);
               numbers.Add(number);
            }
            else if (argsCMD[0] == "Insert")
            {
               int number = int.Parse(argsCMD[1]);
               int index = int.Parse(argsCMD[2]);
               if (index < 0 || index > numbers.Count - 1)
               {
                  Console.WriteLine("Invalid index");

               }
               else
               {
                  numbers.Insert(index, number);
               }
            }
            else if (argsCMD[0] == "Remove")
            {
               int index = int.Parse(argsCMD[1]);
               if (index < 0 || index > numbers.Count - 1)
               {
                  Console.WriteLine("Invalid index");

               }
               else
               {
                  numbers.RemoveAt(index);
               }
            }
            else if (argsCMD[1] == "left")
            {
               int shiftCount = int.Parse(argsCMD[2]);
               for (int i = 0; i < shiftCount % numbers.Count; i++)
               {
                  int tempNumber = numbers[0];
                  numbers.RemoveAt(0);
                  numbers.Add(tempNumber);

               }

            }
            else if (argsCMD[1] == "right")
            {
               int shiftCount = int.Parse(argsCMD[2]);
               for (int i = 0; i < shiftCount % numbers.Count; i++)
               {
                  int tempLastNumber = numbers[numbers.Count - 1];
                  numbers.RemoveAt(numbers.Count - 1);
                  numbers.Insert(0, tempLastNumber);
               }

            }
            cmd = Console.ReadLine();
         }

         Console.WriteLine(string.Join(" ", numbers));
      }
   }
}
