using System;
using System.Linq;

namespace _07._Equal_Arrays
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] firstArray = Console.ReadLine().Split()
               .Select(int.Parse).ToArray();
         int[] secondArray = Console.ReadLine().Split()
               .Select(int.Parse).ToArray();

         int sum = 0;
         bool isIdentical = false;
         int index = 0;
         for (int i = 0; i < firstArray.Length; i++)
         {
            if (firstArray[i] == secondArray[i])
            {
               isIdentical = true;
               sum += firstArray[i];
            }
            else
            {
               isIdentical = false;
               index = i;
               break;
            }
         }

         if (isIdentical)
         {
            Console.WriteLine($"Arrays are identical. Sum: {sum}");

         }
         else
         {
            Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
         }
      }
   }
}
