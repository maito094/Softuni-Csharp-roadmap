using System;
using System.Collections.Generic;

namespace Stacks_and_Queues
{
   class Program
   {
      static void Main(string[] args)
      {
         string input = Console.ReadLine();
         Stack<char> stringStack = new Stack<char>();

         for (int i = 0; i < input.Length; i++)
         {
            stringStack.Push(input[i]);
         }

         while (stringStack.Count > 0)
         {
            Console.Write(stringStack.Pop());
         }

      }
   }
}
