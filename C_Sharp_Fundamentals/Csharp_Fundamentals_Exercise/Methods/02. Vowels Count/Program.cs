using System;
using System.Linq;

namespace _02._Vowels_Count
{
   class Program
   {
      static void Main(string[] args)
      {

         string inpText = Console.ReadLine();
         int countVowels = getVowelsCount(inpText);
         Console.WriteLine(countVowels);
      }

      static int getVowelsCount(string text)
      {
         char[] vowels = { 'a', 'i', 'u', 'e', 'o' };

         int countVowels = 0;
         for (int j = 0; j < text.Length; j++)
         {
            for (int i = 0; i < vowels.Length; i++)
            {
               if (char.ToLower(text[j]) == (vowels[i]))
               {
                  countVowels++;
               }
            }

         }
         return countVowels;
      }
   }
}
