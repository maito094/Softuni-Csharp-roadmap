using System;

namespace _05._Top_Integers_v2
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] input = Console.ReadLine().Split();

         int topInteger = 0;

         for (int i = 0; i < input.Length; i++)
         {
            topInteger = int.Parse(input[i]);

            for (int j = i + 1; j <= input.Length; j++)
            {
               if (j == input.Length)
               {
                  Console.Write($"{topInteger} ");
                  break;
               }
               else if ((topInteger < int.Parse(input[j])) || (topInteger == int.Parse(input[j])))
               {
                  break;
               }

            }
         }
      }
   }
}
