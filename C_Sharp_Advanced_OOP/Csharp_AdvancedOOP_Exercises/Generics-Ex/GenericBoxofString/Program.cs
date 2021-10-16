using System;

namespace GenericBoxofString
{
 public  class Program
   {
      static void Main(string[] args)
      {
         Box<string> box = new Box<string>();

         int n = int.Parse(Console.ReadLine());

         for (int i = 0; i < n; i++)
         {
            var input = Console.ReadLine();
            box.Item.Add(input);
         }

         Console.WriteLine(box.ToString());

      }
   }
}
