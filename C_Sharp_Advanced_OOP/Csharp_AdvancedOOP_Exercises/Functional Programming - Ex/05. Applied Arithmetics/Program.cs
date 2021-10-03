using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
   class Program
   {
      static void Main(string[] args)
      {

         int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

         Func<int, int> arithmeticOperation = null;


         while (true)
         {
            string cmd = Console.ReadLine();

            if (cmd == "end")
            {
               break;
            }
            else if (cmd == "add")
            {
               arithmeticOperation = number => number += 1;
            }
            else if (cmd == "multiply")
            {
               arithmeticOperation = number => number *= 2;
            }
            else if (cmd == "subtract")
            {
               arithmeticOperation = number => number -= 1;
            }
            else if (cmd == "print")
            {
               Console.WriteLine(string.Join(" ", numbers));
               continue;
            }

            numbers = numbers.Select(arithmeticOperation).ToArray();

         }

      }
   }
}
