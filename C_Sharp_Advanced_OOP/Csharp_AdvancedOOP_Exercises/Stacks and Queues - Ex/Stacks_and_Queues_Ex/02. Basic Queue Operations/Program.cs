using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
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


         Queue<int> numbers = new Queue<int>();

         int elementsToEnqueue = numOperations[0];
         int elementsToDequeue = numOperations[1];
         int elementToFind = numOperations[2];


         for (int i = 0; i < elementsToEnqueue; i++)
         {
            numbers.Enqueue(arrayNum[i]);
         }
         for (int i = 0; i < elementsToDequeue; i++)
         {
            numbers.Dequeue();
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
