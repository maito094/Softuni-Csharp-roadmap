using System;
using System.Text;

namespace _04._Text_Filter
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] bannedWords = Console.ReadLine().Split(", ");
         StringBuilder text = new StringBuilder(Console.ReadLine());

         foreach (var banWord in bannedWords)
         {
            text.Replace(banWord, new string('*', banWord.Length));
         }
         Console.WriteLine(text);
      }
   }
}
