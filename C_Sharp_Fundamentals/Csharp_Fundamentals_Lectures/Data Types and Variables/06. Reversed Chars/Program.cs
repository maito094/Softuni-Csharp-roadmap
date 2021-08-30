using System;

namespace _06._Reversed_Chars
{
   class Program
   {
      static void Main(string[] args)
      {
         string text = string.Empty;
         for (int i = 0; i < 3; i++)
         {
            text += Console.ReadLine();
         }

         Console.WriteLine($"{text[2]} {text[1]} {text[0]}");
      }
   }
}
