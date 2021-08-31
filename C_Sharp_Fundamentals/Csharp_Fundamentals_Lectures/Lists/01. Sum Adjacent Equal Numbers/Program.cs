using System;
using System.Collections.Generic;

namespace _01._Sum_Adjacent_Equal_Numbers
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());
         // string[] names = new string[n];
         List<string> names = new List<string>();


         for (int i = 0; i < n; i++)
         {
            string name = Console.ReadLine();
            names.Add(name);
            // names[i] = name;
            Console.WriteLine(names[i]);
         }
         Console.WriteLine(string.Join(" ", names));
      }
   }
}
