using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
   class Program
   {
      static void Main(string[] args)
      {
         string input = Console.ReadLine();
         string patternMatch = @"%(?<customer>[A-Z][a-z]+)%[^\|\$\%\.]*<(?<product>\w+)>[^\|\$\%\.]*\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>[0-9]+\.{0,1}[0-9]{0,2})\$";
         decimal totalIncome = 0;

         while (!input.Contains("end of shift"))
         {
            bool isMatch = Regex.IsMatch(input, patternMatch);

            if (isMatch)
            {
               Match match = Regex.Match(input, patternMatch);
               string customerName = match.Groups["customer"].Value;
               string product = match.Groups["product"].Value;
               int count = int.Parse(match.Groups["count"].Value);
               decimal price = decimal.Parse(match.Groups["price"].Value);
               decimal totalPrice = count * price;
               totalIncome += totalPrice;
               Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");
            }

            input = Console.ReadLine();
         }

         Console.WriteLine($"Total income: {totalIncome:f2}");
      }
   }
}
