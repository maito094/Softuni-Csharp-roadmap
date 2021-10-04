using System;

namespace _04._Bit_Destroyer
{
   class Program
   {
      static void Main(string[] args)
      {
         int num = int.Parse(Console.ReadLine());
         int positionDestroy = int.Parse(Console.ReadLine());

         int mask = 1;
         mask = mask << positionDestroy;
         int newNum = num & (~mask);
         Console.WriteLine(newNum);
         //  uint destroyNumber = 0;/// UNSIGNED MUST BE USED
         //  destroyNumber= Convert.ToUInt32(Math.Pow(2, positionDestroy));
         //  destroyNumber=~destroyNumber;
         // // Console.WriteLine(Convert.ToString(destroyNumber,2));
         ////  Console.WriteLine(Convert.ToString(num,2));
         //  num=(num & destroyNumber);
         // // Console.WriteLine(Convert.ToString(num,2));
         //  Console.WriteLine(num);
      }
   }
}
