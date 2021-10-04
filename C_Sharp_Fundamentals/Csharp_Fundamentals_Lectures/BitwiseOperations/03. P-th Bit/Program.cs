using System;

namespace _03._P_th_Bit
{
   class Program
   {
      static void Main(string[] args)
      {
         int num = int.Parse(Console.ReadLine());
         int positionBinary = int.Parse(Console.ReadLine());
         bool[] numBinary = new bool[positionBinary+1];
         int iterator = 0;
         while (iterator <= positionBinary)
         {
            numBinary[iterator] = Convert.ToBoolean(num % 2);
            iterator++;
            num /= 2;
         }
         Console.WriteLine(string.Join("\n", numBinary[positionBinary] == true ? 1 : 0));
      }
   }

}
