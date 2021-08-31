using System;

namespace _04._Reverse_Array_of_Strings
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] input = Console.ReadLine().Split();

         for (int i = 0; i < input.Length / 2; i++)
         {
            string temp = input[i];
            input[i] = input[input.Length - 1 - i];
            input[input.Length - 1 - i] = temp;
         }

         foreach (var item in input)
         {
            Console.Write($"{item} ");
         }

        // Console.WriteLine(string.Join(" ", input)); Same as Foreach upper ex
      }
   }
}
