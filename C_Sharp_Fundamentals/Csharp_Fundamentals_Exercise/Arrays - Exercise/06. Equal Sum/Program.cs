using System;
using System.Linq;

namespace _06._Equal_Sum
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
         for (int i = 0; i < input.Length; i++)
         {
            int leftSum = 0;
            int rightSum = 0;

            for (int j = 0; j <= i; j++)
            {
               leftSum += input[j];
            }
            for (int j = input.Length - 1; j >= i; j--)
            {

               rightSum += input[j];
            }

            if ((leftSum == rightSum) && (leftSum > 0 && rightSum > 0))
            {
               Console.WriteLine(i);
               break;
            }
            else if (input.Length == 1)
            {
               Console.WriteLine(0);
               break;
            }
            else if (i >= input.Length - 1)
            {
               Console.WriteLine("no");
               break;
            }

         }

      }
   }
}


