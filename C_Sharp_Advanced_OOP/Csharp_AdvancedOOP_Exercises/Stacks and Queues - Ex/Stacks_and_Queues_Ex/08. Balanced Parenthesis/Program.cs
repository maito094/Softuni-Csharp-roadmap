using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
   class Program
   {
      static void Main(string[] args)
      {
         string input = Console.ReadLine();

         Stack<char> parantheses = new Stack<char>();

         bool isBalanced = true;
         if (input.Length % 2 != 0)
         {
            isBalanced = false;
         }
         foreach (var sym in input)
         {
            if (!isBalanced)
            {
               break;
            }

            if (sym == '{' || sym == '(' || sym == '[')
            {
               parantheses.Push(sym);
            }
            else
            {
               if (parantheses.Count == 0)
               {
                  isBalanced = false;
                  // break;
               }
               bool isParenthesisValid = (sym == '}' && parantheses.Peek() == '{')
                                    || (sym == ')' && parantheses.Peek() == '(')
                                    || (sym == ']' && parantheses.Peek() == '[');
               if (isParenthesisValid)
               {
                  parantheses.Pop();
               }
               else
               {
                  isBalanced = false;
                  //  break;
               }
            }
         }

         Console.WriteLine(isBalanced ? "YES" : "NO");
      }
   }
}
