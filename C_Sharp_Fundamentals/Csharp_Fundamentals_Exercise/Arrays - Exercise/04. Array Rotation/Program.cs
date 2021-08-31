using System;
using System.Linq;

namespace _04._Array_Rotation
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
         int numRotatiions = int.Parse(Console.ReadLine());

         for (int i = 0; i < numRotatiions; i++)
         {
            int tmp = arr[0];

            for (int j = 0; j < arr.Length - 1; j++)
            {

               arr[j] = arr[j + 1];

            }
            arr[arr.Length - 1] = tmp;

         }
         Console.WriteLine(string.Join(" ", arr));
      }
   }
}
