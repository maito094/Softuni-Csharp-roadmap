using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
   class Program
   {
      static void Main(string[] args)
      {
         int numberOfEntries = int.Parse(Console.ReadLine());

         Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();


         for (int i = 0; i < numberOfEntries; i++)
         {
            var lines = Console.ReadLine().Split(" ");

            string continent = lines[0];
            string country = lines[1];
            string city = lines[2];

            if (!continents.ContainsKey(continent))
            {
               continents[continent] = new Dictionary<string, List<string>>();
            }
            if (!continents[continent].ContainsKey(country))
            {
               continents[continent][country] = new List<string>();
            }

            continents[continent][country].Add(city);

         }

         foreach (var continent in continents)
         {
            Console.WriteLine(continent.Key + ":");

            foreach (var country in continent.Value)
            {
               Console.WriteLine($" {country.Key} -> {string.Join(", ", country.Value)}");
            }

         }

      }
   }
}
