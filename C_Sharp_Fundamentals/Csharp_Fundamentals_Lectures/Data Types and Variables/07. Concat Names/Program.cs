using System;

namespace _07._Concat_Names
{
   class Program
   {
      static void Main(string[] args)
      {
         string firstName = string.Empty;
         string secondName = string.Empty;

         firstName = Console.ReadLine();
         secondName = Console.ReadLine();
         string delimeter = Console.ReadLine();

         Console.WriteLine($"{firstName}{delimeter}{secondName}");
      }
   }
}
