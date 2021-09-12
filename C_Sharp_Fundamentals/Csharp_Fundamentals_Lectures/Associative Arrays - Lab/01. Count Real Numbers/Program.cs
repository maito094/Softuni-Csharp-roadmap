using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
   class Program
   {
      static void Main(string[] args)
      {
         double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

         SortedDictionary<double, int> realNumbers = new SortedDictionary<double, int>();

         for (int i = 0; i < numbers.Length; i++)
         {
            if (!realNumbers.ContainsKey(numbers[i]))
            {
               realNumbers.Add(numbers[i], 0);
            }
            realNumbers[numbers[i]]++;
         }

         foreach (var item in realNumbers)
         {
            Console.WriteLine(string.Join(Environment.NewLine, $"{item.Key} -> {item.Value}"));
         }
      }
   }
}
