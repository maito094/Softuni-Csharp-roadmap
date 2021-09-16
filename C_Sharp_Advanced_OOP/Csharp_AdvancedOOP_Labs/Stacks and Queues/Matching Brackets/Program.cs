using System;
using System.Collections.Generic;

namespace Matching_Brackets
{
   class Program
   {
      static void Main(string[] args)
      {
         string input = Console.ReadLine();


         Stack<int> indexOfExpression = new Stack<int>();      // Find First Closing Bracket and Match it with last Opening Bracket

         for (int i = 0; i < input.Length; i++)
         {
            int openBracketIndex = 0;
            string expression = string.Empty;

            if (input[i] == '(')
            {
               indexOfExpression.Push(i);
            }

            else if (input[i] == ')')
            {
               openBracketIndex = indexOfExpression.Pop();
               expression = input.Substring(openBracketIndex, i - openBracketIndex + 1);
               Console.WriteLine(expression);
               
            }
         }

      }
   }
}
