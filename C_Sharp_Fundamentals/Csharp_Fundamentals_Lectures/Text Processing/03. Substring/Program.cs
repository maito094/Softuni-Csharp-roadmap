using System;

namespace _03._Substring
{
   class Program
   {
      static void Main(string[] args)
      {
         string keyWord = Console.ReadLine().ToLower();
         string text = Console.ReadLine();

         while (text.Contains(keyWord))
         {
            text = text.Replace(keyWord,"");
         }
         Console.WriteLine(text);
      }
   }
}
