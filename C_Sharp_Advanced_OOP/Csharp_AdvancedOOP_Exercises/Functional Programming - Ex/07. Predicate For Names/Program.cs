using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
   class Program
   {
      static void Main(string[] args)
      {

         Func<string, int, bool> nameLength = (name, length) => name.Length <= length;

         int maxLengthNames = int.Parse(Console.ReadLine());

         string[] names = Console.ReadLine()
                                 .Split(" ")
                                 .Where(x => nameLength(x, maxLengthNames))
                                 .ToArray();

         foreach (var name in names)
         {
            Console.WriteLine(name);
         }
      }
   }
}
