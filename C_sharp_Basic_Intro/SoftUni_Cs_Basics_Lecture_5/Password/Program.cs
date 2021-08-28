using System;

namespace Password
{
   class Program
   {
      static void Main(string[] args)
      {
         string user = Console.ReadLine();
         string pass = Console.ReadLine();
         string guessPass = Console.ReadLine();

         while (pass != guessPass)
         {
            guessPass = Console.ReadLine();
         }

         Console.WriteLine($"Welcome {user}!");
      }
   }
}
