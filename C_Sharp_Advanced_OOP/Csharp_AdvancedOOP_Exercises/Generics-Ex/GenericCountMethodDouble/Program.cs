using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());
         Box<double> box = new Box<double>();

         for (int i = 0; i < n; i++)
         {
            box.Item.Add(double.Parse(Console.ReadLine()));
         }

         double compareToDouble = double.Parse(Console.ReadLine());

         Console.WriteLine(box.CountListElements(box.Item, compareToDouble));

      }

   }

}
