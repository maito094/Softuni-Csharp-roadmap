using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
   class Program
   {
      static void Main(string[] args)
      {

         string input = Console.ReadLine();
         int digitMultiplier = int.Parse(Console.ReadLine());
         int reminder = 0;
         StringBuilder resultNum = new StringBuilder();

         if (input == "0" || digitMultiplier == 0)
         {
            Console.WriteLine(0);
            return;
         }
         for (int i = input.Length - 1; i >= 0; i--)
         {

            int currentDigit = int.Parse(input[i].ToString());
            int product = (currentDigit * digitMultiplier) + reminder;

            int result = product % 10;
            reminder = product / 10;
            resultNum.Insert(0, result);

         }
         if (reminder > 0)
         {
            resultNum.Insert(0, reminder);
         }
         Console.WriteLine(resultNum);
      }
   }
}
