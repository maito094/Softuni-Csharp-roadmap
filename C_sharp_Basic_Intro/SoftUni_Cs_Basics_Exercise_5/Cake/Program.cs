using System;

namespace Cake
{
   class Program
   {
      static void Main(string[] args)
      {
         int widthCake = int.Parse(Console.ReadLine());
         int lenghtCake = int.Parse(Console.ReadLine());
         int wholeCake = widthCake * lenghtCake;
         string numPieaces = Console.ReadLine(); ; //1cm x 1cm

         while (numPieaces != "STOP")
         {


            wholeCake -= int.Parse(numPieaces);


            if (wholeCake < 0)
            {
               Console.WriteLine($"No more cake left! You need {Math.Abs(wholeCake)} pieces more.");
               break;
            }
            numPieaces = Console.ReadLine();

         }
         if (numPieaces == "STOP" && wholeCake >= 0)
         {
            Console.WriteLine($"{wholeCake} pieces are left.");

         }
      }
   }
}
