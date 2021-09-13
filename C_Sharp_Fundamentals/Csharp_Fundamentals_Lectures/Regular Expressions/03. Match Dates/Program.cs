using System;
using System.Text;
using System.Text.RegularExpressions;
namespace _03._Match_Dates
{
   class Program
   {
      static void Main(string[] args)
      {

         //13/Jul/1928, 10-Nov-1934, 25.Dec.1937	01/Jan-1951, 23/sept/1973, 1/Feb/2016

         string input = Console.ReadLine();

         string patternDate = @"\b(?<day>[0-9]{2})(?<delimeter>\W)(?<month>[A-Z][a-z]{2})\k<delimeter>(?<year>[0-9]{4})\b";

         MatchCollection matchesDate = Regex.Matches(input, patternDate);

         foreach (Match date in matchesDate)
         {
            var day = date.Groups["day"].Value;
            var month = date.Groups["month"].Value;
            var year = date.Groups["year"].Value;

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
         }

         //for (int i = 0; i < matchesDate.Count; i++)
         //{
         //   Console.WriteLine($"Day: {matchesDate[i].Groups["day"].Value}, Month: {matchesDate[i].Groups["month"].Value}, Year: {matchesDate[i].Groups["year"].Value}");
         //}

      }
   }
}
