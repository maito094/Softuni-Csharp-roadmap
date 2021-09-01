using System;
using System.Linq;

namespace _01._Reverse_Strings
{
   class Program
   {
      static void Main(string[] args)
      {

         string input = Console.ReadLine();

         while (input != "end")
         {
            char[] reverseInput = input.Reverse().ToArray();
            string result = string.Join("", reverseInput);
            Console.WriteLine($"{input} = {result}");

            input = Console.ReadLine();
         }
      }
   }
}
