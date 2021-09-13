using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
   class Program
   {
      static void Main(string[] args)
      {
         Dictionary<string, int> racers = new Dictionary<string, int>();

         racers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToDictionary(k => k, v => 0);

         string input = Console.ReadLine();

         string pattern = @"(?<name>[A-Za-z])|(?<digit>[0-9])"; //Group 1 Words //Group 2 digits
         while (!input.Contains("end of race"))
         {

            MatchCollection matches = Regex.Matches(input, pattern);


            StringBuilder name = new StringBuilder();
            int distance = 0;

            foreach (Match match in matches)
            {
               name.Append(match.Groups["name"].Value);

               if (char.IsDigit(match.Value.ToCharArray()[0]))
               {

                  distance += int.Parse(match.Groups["digit"].Value);
               }
            }

            if (racers.ContainsKey(name.ToString()))
            {
               racers[name.ToString()] += distance;
            }

            input = Console.ReadLine();
         }

         racers = racers.OrderByDescending(k => k.Value).Where((k, index) => index < 3).ToDictionary(k => k.Key, v => v.Value);


         Console.WriteLine($"1st place: {racers.ElementAt(0).Key}\n2nd place: {racers.ElementAt(1).Key}\n3rd place: {racers.ElementAt(2).Key}");

      }
   }
}
