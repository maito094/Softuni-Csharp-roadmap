﻿using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
   class Program
   {
      static void Main(string[] args)
      {
         StringBuilder input = new StringBuilder(Console.ReadLine());

         for (int i = 0; i < input.Length - 1; i++)
         {
            if (input[i] != input[i + 1])
            {
               Console.Write(input[i]);
            }
         }
         Console.WriteLine(input[input.Length - 1]);
      }
   }
}
