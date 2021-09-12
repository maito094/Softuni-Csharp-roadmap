using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
   class Program
   {
      static void Main(string[] args)
      {

         string[] input = Console.ReadLine().Split(" -> ");

         Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

         while (input[0] != "End")
         {
            string companyName = input[0];
            string employeeID = input[1];

            if (!companies.ContainsKey(companyName))
            {
               companies.Add(companyName, new List<string>());

            }
            if (!companies[companyName].Contains(employeeID))
            {
               companies[companyName].Add(employeeID);
            }

            input = Console.ReadLine().Split(" -> ");
         }

         companies = companies.OrderBy(o => o.Key).ToDictionary(k => k.Key, v => v.Value);

         foreach (var company in companies)
         {
            Console.WriteLine(company.Key);

            for (int i = 0; i < company.Value.Count; i++)
            {

               Console.WriteLine($"-- {company.Value[i]}");
            }
         }
      }
   }
}
