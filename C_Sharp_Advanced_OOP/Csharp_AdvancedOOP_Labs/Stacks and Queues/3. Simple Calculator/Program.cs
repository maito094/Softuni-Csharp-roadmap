using System;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
   class Program
   {
      static void Main(string[] args)
      {
         string input = Console.ReadLine();
         Stack<string> expression = new Stack<string>(input.Split(" "));

         int sum = 0;

         while (expression.Count > 0)
         {
            int currentNum = int.Parse(expression.Pop());

            if (expression.Count > 1)
            {
               if (expression.Peek() == "+")
               {
                  sum += currentNum;
               }
               else if (expression.Peek() == "-")
               {
                  sum -= currentNum;
               }
               expression.Pop();
            }
            else
            {
               sum += currentNum;
            }
         }


         Console.WriteLine(sum);
      }
   }
}
