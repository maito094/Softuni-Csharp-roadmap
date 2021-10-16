using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());
         Box<string> box = new Box<string>();

         for (int i = 0; i < n; i++)
         {
            box.Item.Add(Console.ReadLine());
         }

         string compareToString = Console.ReadLine();

         Console.WriteLine(box.CountListElements(box.Item, compareToString));

      }

   }

}
