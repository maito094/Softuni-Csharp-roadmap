using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sum_Numbers
{
   class Program
   {
      static void Main(string[] args)
      {
         List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

         int sumNumbers = numbers.Sum();
         int countNumbers = numbers.Count();

         Console.WriteLine(countNumbers);
         Console.WriteLine(sumNumbers);
      }
   }
}
