using System;

using System.Collections.Generic;


namespace _01._Count_Same_Values_in_Array
{
   class Program
   {
      static void Main(string[] args)
      {

         var line = Console.ReadLine();
         var numbersAsStringList = line.Split(' ');

         Dictionary<double, int> numbers = new Dictionary<double, int>();


         foreach (var numberAsString in numbersAsStringList)
         {
            double number = double.Parse(numberAsString);
            if (!numbers.ContainsKey(number))
            {
               numbers.Add(number, 0);
            }

            numbers[number]++;
         }

         foreach (var number in numbers)
         {
            Console.WriteLine($"{number.Key} - {number.Value} times");
         }

      }
   }
}
