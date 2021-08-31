using System;
using System.Collections.Generic;
using System.Linq;


namespace _08.Anonymous_Threat
{
   class Program
   {
      static void Main(string[] args)
      {
         List<string> inputLine = Console.ReadLine()
                          .Split()
                          .ToList();

         string cmdLine = Console.ReadLine();

         //merge 0 3
         //divide 4 5


         while (cmdLine != "3:1")
         {
            string[] commandArgs = cmdLine.Split();
            string action = commandArgs[0];

            if (action == "merge")
            {
               int startIndex = int.Parse(commandArgs[1]);
               int endIndex = int.Parse(commandArgs[2]);
               //{ abc, def, ghi} -> 
               //merge 0 1-> 
               //{ abcdef, ghi}
               if (startIndex < 0 || startIndex > inputLine.Count - 1)
               {
                  startIndex = 0;
               }
               if (endIndex > inputLine.Count - 1)
               {
                  endIndex = inputLine.Count - 1;
               }
               if (startIndex == endIndex)
               {
                  cmdLine = Console.ReadLine();
                  continue;
               }
               for (int i = startIndex; i < endIndex; i++)
               {

                  inputLine[startIndex] = string.Concat(inputLine[startIndex], inputLine[i + 1]);

               }
               inputLine.RemoveRange(startIndex + 1, ((endIndex - startIndex)));

            }
            else if (action == "divide")
            {
               int index = int.Parse(commandArgs[1]);
               int partitions = int.Parse(commandArgs[2]);

               bool isOdd = false;
               string currentInputLine = inputLine[index];

               if (partitions > currentInputLine.Length)
               {
                  partitions = currentInputLine.Length;
               }

               int helpSubStringIndex = 0;
               int lastIndexInputLine = 0;
               for (int i = 0; i < partitions; i++)   //(inputLine[index].Length + helpEvenParts) / 2
               {
                  lastIndexInputLine = index + i;
                  inputLine.Insert(index + i, currentInputLine.Substring(helpSubStringIndex, inputLine[index + i].Length / partitions));
                  helpSubStringIndex += currentInputLine.Length / partitions;
                  if ((partitions <= i + helpSubStringIndex) && currentInputLine.Length % partitions != 0)
                  {
                     isOdd = true;
                     break;
                  }
               }
               if (isOdd)
               {
                  inputLine.Insert(lastIndexInputLine + 1, currentInputLine.Substring(helpSubStringIndex, ((1 + partitions) - helpSubStringIndex)));
                  lastIndexInputLine++;
               }
               inputLine.RemoveAt(lastIndexInputLine + 1);
            }


            cmdLine = Console.ReadLine();
         }

         Console.WriteLine(string.Join(" ", inputLine));
      }
   }
}
