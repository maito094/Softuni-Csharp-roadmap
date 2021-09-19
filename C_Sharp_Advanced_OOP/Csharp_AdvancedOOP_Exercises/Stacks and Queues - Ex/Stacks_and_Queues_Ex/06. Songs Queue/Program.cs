using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
   class Program
   {
      static void Main(string[] args)
      {

         Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));


         while (true)
         {
            string command = Console.ReadLine();


            if (command.Contains("Play"))
            {

               songs.Dequeue();

            }
            else if (command.Contains("Add"))
            {
               string[] helpstring = command.Split("Add ");


               string nameSong = helpstring[1];
               if (songs.Contains(nameSong))
               {
                  Console.WriteLine($"{nameSong} is already contained!");
               }
               else
               {
                  songs.Enqueue(nameSong);

               }

            }
            else if (command.Contains("Show"))
            {
               Console.Write(string.Join(", ", songs));
               Console.WriteLine();
            }

            if (songs.Count < 1)
            {
               Console.WriteLine("No more songs!");
               break;

            }

         }

      }
   }
}
