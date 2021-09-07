using System;
using System.Collections.Generic;

namespace _03._Songs
{
   class Program
   {
      static void Main(string[] args)
      {
         int numSongs = int.Parse(Console.ReadLine());

         Song[] songs = new Song[numSongs];
         for (int i = 0; i < numSongs; i++)
         {
            string cmd = Console.ReadLine();
            string typeList = cmd.Split("_")[0];
            string name = cmd.Split("_")[1];
            string time = cmd.Split("_")[2];
            songs[i] = new Song(typeList, name, time);
         }

         string calledTypeList = Console.ReadLine();


         foreach (var song in songs)
         {
            if (calledTypeList == "all")
            {
               Console.WriteLine(song.Name);
            }
            else if (song.TypeList == calledTypeList)
            {
               Console.WriteLine(song.Name);
            }
         }

      }
   }
   class Song
   {
      public string TypeList { get; set; }
      public string Name { get; set; }
      public string Time { get; set; }

      public Song(string typeList, string name, string time)
      {
         TypeList = typeList;
         Name = name;
         Time = time;
      }
      public Song()
      {

      }


   }
}
