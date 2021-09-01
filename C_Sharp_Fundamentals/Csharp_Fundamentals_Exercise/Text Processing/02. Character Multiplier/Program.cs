using System;

namespace _02._Character_Multiplier
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] input = Console.ReadLine().Split();
         int totalSum = 0;
         totalSum = CharCodeMultiply(input[0], input[1]);
         Console.WriteLine(totalSum);
      }

      static int CharCodeMultiply(string first, string second)
      {
         int sum = 0;
         int n = 0;
         if (first.Length < second.Length)
         {
            n = first.Length;

            for (int j = n; j < second.Length; j++)
            {
               int charCodeSecond = second[j];
               sum += charCodeSecond;
            }
         }
         else if (first.Length == second.Length)
         {
            n = first.Length;
         }
         else
         {
            n = second.Length;

            for (int j = n; j < first.Length; j++)
            {
               int charCodeFirst = first[j];
               sum += charCodeFirst;
            }
         }
         for (int i = 0; i < n; i++)
         {

            int charCodeFirst = first[i];
            int charCodeSecond = second[i];
            sum += (charCodeFirst * charCodeSecond);//(charCodeFirst + charCodeSecond) + 
         }


         return sum;
      }
   }

}
