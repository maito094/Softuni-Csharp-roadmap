using System;

namespace MaxNumber
{
   class Program
   {
      static void Main(string[] args)
      {
         int maxNum = int.MinValue;
         string num = Console.ReadLine();

         while (num != "Stop")
         {
            if (int.Parse(num) > maxNum)
            {
               maxNum = int.Parse(num);
            }
            num = Console.ReadLine();
         }
         Console.WriteLine(maxNum);
      }
   }
}
