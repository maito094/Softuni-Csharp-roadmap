using System;

namespace SmallestNumber
{
   class Program
   {
      static void Main(string[] args)
      {
         int minNum = int.MaxValue;
         string num = Console.ReadLine();

         while (num != "Stop")
         {
            if (int.Parse(num) < minNum)
            {
               minNum = int.Parse(num);
            }
            num = Console.ReadLine();
         }
         Console.WriteLine(minNum);
      }
   }
}
