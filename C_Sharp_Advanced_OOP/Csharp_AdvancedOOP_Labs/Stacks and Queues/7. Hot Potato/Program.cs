using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] children = Console.ReadLine().Split(" ");
         Queue<string> players = new Queue<string>(children);

         int nthPlayerOut = int.Parse(Console.ReadLine());

         while (players.Count > 1)
         {
            for (int i = 1; i < nthPlayerOut; i++)
            {
               players.Enqueue(players.Dequeue());
            }
            Console.WriteLine("Removed " + players.Dequeue());
         }
         Console.WriteLine("Last is " + players.Dequeue());
      }
   }
}
