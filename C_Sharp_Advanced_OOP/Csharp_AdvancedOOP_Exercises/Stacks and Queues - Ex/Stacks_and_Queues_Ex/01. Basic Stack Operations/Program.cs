using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] numOperations = Console.ReadLine()
                                     .Split(" ")
                                     .Select(int.Parse)
                                     .ToArray();

         int[] arrayNum = Console.ReadLine()
                                     .Split(" ")
                                     .Select(int.Parse)
                                     .ToArray();


         Stack<int> numbers = new Stack<int>();

         int elementsToPush = numOperations[0];
         int elementsToPop = numOperations[1];
         int elementToFind = numOperations[2];


         for (int i = 0; i < elementsToPush; i++)
         {
            numbers.Push(arrayNum[i]);
         }
         for (int i = 0; i < elementsToPop; i++)
         {
            numbers.Pop();
         }


         if (numbers.Count == 0)
         {
            Console.WriteLine(0);

            Environment.Exit(0);
         }

         int smallest = int.MaxValue;
         bool isFound = false;

         foreach (var number in numbers)
         {

            if (elementToFind == number)
            {
               isFound = true;
            }

            if (number < smallest)
            {
               smallest = number;
            }

         }
         Console.WriteLine(isFound ? isFound.ToString().ToLower() : smallest.ToString());
      }


   }

}
