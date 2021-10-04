using System;

namespace _02._Bit_at_First_Position
{
   class Program
   {
      static void Main(string[] args)
      {
         int num = int.Parse(Console.ReadLine());
         bool[] numBinary = new bool[2];
         int iterator = 0;
         while (iterator <= 1)
         {
            numBinary[iterator] = Convert.ToBoolean(num % 2);
            iterator++;
            num /= 2;
         }
         Console.WriteLine(string.Join("\n", numBinary[1] == true ? 1 : 0));
      }
   }
}
