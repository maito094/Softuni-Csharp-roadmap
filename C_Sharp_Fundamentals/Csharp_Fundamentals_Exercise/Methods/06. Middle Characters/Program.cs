using System;

namespace _06._Middle_Characters
{
   class Program
   {
      static void Main(string[] args)
      {
         string input = Console.ReadLine();
         string result = GetMiddleChars(input);
         // even => 2 chars
         // odd => 1 char
         // middle of string char

         Console.WriteLine(result);
      }
      static string GetMiddleChars(string inputText)
      {
         string result = string.Empty;

         if (inputText.Length % 2 == 0)
         {

            result = $"{inputText[(inputText.Length / 2) - 1]}{inputText[inputText.Length / 2]}";
         }
         else
         {
            result = inputText[(inputText.Length / 2)].ToString();
         }
         return result;
      }
   }
}
