using System;
using System.Text;

namespace _04._Caesar_Cipher
{
   class Program
   {
      static void Main(string[] args)
      {
         StringBuilder inputText = new StringBuilder(Console.ReadLine());

         for (int i = 0; i < inputText.Length; i++)
         {
            inputText[i] = (char)((int)inputText[i] + 3);
         }
         Console.WriteLine(inputText);
      }
   }
}
