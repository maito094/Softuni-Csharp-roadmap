using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] sequence = Console.ReadLine().Split()
               .Select(int.Parse).ToArray();

         int maxElements = 0;
         int currentEqualElements = 1;
         int currentSequenceNumber = 0;
         for (int i = 0; i < sequence.Length - 1; i++)
         {
            if (sequence[i] == sequence[i + 1])
            {
               currentEqualElements++;
            }
            else
            {
               currentEqualElements = 1;
            }
            if (currentEqualElements > maxElements)
            {

               maxElements = currentEqualElements;
               currentSequenceNumber = sequence[i];

            }
         }
         for (int i = 0; i < maxElements; i++)
         {
            Console.Write($"{currentSequenceNumber} ");

         }
      }
   }
}
