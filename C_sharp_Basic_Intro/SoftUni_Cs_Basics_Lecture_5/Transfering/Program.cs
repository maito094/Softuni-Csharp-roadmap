using System;

namespace Transfering
{
   class Program
   {
      static void Main(string[] args)
      {
         int width = int.Parse(Console.ReadLine());
         int length = int.Parse(Console.ReadLine());
         int height = int.Parse(Console.ReadLine());

         int numBoxes = 0;
         int freespace = (width * length * height);
         string sNumBoxes = "";

         while (freespace > 0)
         {
            sNumBoxes = (Console.ReadLine());
            if (sNumBoxes == "Done")
            {
               Console.WriteLine($"{freespace} Cubic meters left.");
               break;
            }
            numBoxes = int.Parse(sNumBoxes);
            freespace -= numBoxes;

         }
         if (freespace <= 0)
         {
            Console.WriteLine($"No more free space! You need {Math.Abs(freespace)} Cubic meters more.");

         }

      }
   }
}
