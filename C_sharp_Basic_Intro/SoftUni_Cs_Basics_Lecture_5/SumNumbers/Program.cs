﻿using System;

namespace SumNumbers
{
   class Program
   {
      static void Main(string[] args)
      {
         int number = int.Parse(Console.ReadLine());
         int n = int.Parse(Console.ReadLine());
         int sum = n;
         while (number > sum)
         {
            n = int.Parse(Console.ReadLine());
            sum += n;
         }
         Console.WriteLine(sum);
      }
   }
}
