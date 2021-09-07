using System;

namespace _07._Repeat_String
{
   class Program
   {
      static void Main(string[] args)
      {
         string result = RepeatedString();
         Console.WriteLine(result);
      }
      static string RepeatedString()
      {
         string text = Console.ReadLine();
         int n = int.Parse(Console.ReadLine());
         string result = string.Empty;
         for (int i = 0; i < n; i++)
         {
            result += text;
         }
         return result;
      }
   }
}
