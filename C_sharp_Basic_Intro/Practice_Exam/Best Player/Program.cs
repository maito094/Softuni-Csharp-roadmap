using System;

namespace Best_Player
{
   class Program
   {
      static void Main(string[] args)
      {
         string cmd = "";//= Console.ReadLine();
         string namePlayer = "";
         int numGoals = 0;// int.Parse(Console.ReadLine());

         int maxGoals = 0;

         do
         {
            cmd = Console.ReadLine();
            if (cmd == "END")
            {
               break;
            }
            numGoals = int.Parse(Console.ReadLine());

            if (numGoals > maxGoals)
            {
               maxGoals = numGoals;
               namePlayer = cmd;
            }


         } while (numGoals < 10);


         if (numGoals > maxGoals)
         {
            maxGoals = numGoals;
         }
         Console.WriteLine($"{namePlayer} is the best player!");

         if (maxGoals >= 3)
         {
            Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
         }
         else
         {

            Console.WriteLine($"He has scored {maxGoals} goals.");
         }
      }
   }
}
