using System;

namespace GenericBoxofInteger
{
   public class Program
   {
      static void Main(string[] args)
      {
         Box<int> box = new Box<int>();

         int n = int.Parse(Console.ReadLine());

         for (int i = 0; i < n; i++)
         {
            var input = int.Parse(Console.ReadLine());
            box.Item.Add(input);
         }

         
            Console.WriteLine(box.ToString());
         
      }
   }
}
