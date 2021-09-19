using System;
using System.Collections.Generic;

namespace _03._Maximum_and_Minimum_Element
{
   class Program
   {
      static void Main(string[] args)
      {

         int queries = int.Parse(Console.ReadLine());

         Stack<int> elements = new Stack<int>();

         for (int i = 0; i < queries; i++)
         {
            string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            if (cmd[0] == "1")
            {
               int number = int.Parse(cmd[1]);
               elements.Push(number);

            }
            else if (cmd[0] == "2" && elements.Count > 0)
            {
               elements.Pop();
            }
            else
            {
               if (elements.Count > 0)
               {

                  int minElement = int.MaxValue;
                  int maxElement = int.MinValue;

                  foreach (var number in elements)
                  {
                     if (number > maxElement && cmd[0] == "3")
                     {
                        maxElement = number;
                     }
                     else if (number < minElement && cmd[0] == "4")
                     {
                        minElement = number;
                     }
                  }

                  Console.WriteLine(minElement == int.MaxValue ? maxElement : minElement);

               }
            }

         }

         Console.Write(string.Join(", ", elements));
      }
   }
}
