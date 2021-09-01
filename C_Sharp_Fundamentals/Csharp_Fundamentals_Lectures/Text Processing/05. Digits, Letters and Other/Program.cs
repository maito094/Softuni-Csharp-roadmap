using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
   class Program
   {
      static void Main(string[] args)
      {
         char[] chars = Console.ReadLine().ToCharArray();
         StringBuilder digits = new StringBuilder();
         StringBuilder letters = new StringBuilder();
         StringBuilder otherChars = new StringBuilder();
         for (int i = 0; i < chars.Length; i++)
         {
            if (char.IsDigit(chars[i]))
            {
               digits.Append(chars[i]);
            }
            else if (char.IsLetter(chars[i]))
            {
               letters.Append(chars[i]);
            }
            else
            {
               otherChars.Append(chars[i]);
            }
         }
         Console.WriteLine(digits);
         Console.WriteLine(letters);
         Console.WriteLine(otherChars);
      }
   }
}
