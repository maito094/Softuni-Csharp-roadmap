﻿using System;

namespace _04._Sum_of_Chars
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());
         int sumChars = 0;
         for (int i = 0; i < n; i++)
         {
            char symbol = char.Parse(Console.ReadLine());
            sumChars += (int)symbol;

         }
         Console.WriteLine($"The sum equals: {sumChars}");
      }
   }
}
