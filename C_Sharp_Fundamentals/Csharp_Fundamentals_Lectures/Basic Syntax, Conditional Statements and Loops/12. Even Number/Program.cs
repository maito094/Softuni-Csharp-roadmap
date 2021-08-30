using System;

namespace _12._Even_Number
{
   class Program
   {
      static void Main(string[] args)
      {
         int evenNum;
         do
         {
            evenNum = int.Parse(Console.ReadLine());
            evenNum = Math.Abs(evenNum);

            if (evenNum % 2 != 0)
            {

               Console.WriteLine("Please write an even number.");
            }
            else
            {
               break;
            }

         } while (true);

         Console.WriteLine($"The number is: {evenNum}");
      }
   }
}
