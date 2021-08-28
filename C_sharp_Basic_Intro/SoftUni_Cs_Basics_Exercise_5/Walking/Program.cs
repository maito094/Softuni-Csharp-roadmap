using System;

namespace Walking
{
   class Program

   {
      static void Main(string[] args)
      {
         const int TheGoal = 10000;

         string goal = "";
         int steps = 0; //10 000 is the goal;

         while (steps < TheGoal)
         {
            goal = Console.ReadLine();

            if (goal == "Going home")
            {
               goal = Console.ReadLine();
               steps += int.Parse(goal);
               break;
            }

            steps += int.Parse(goal);

         }

         if (steps >= TheGoal)
         {
            Console.WriteLine("Goal reached! Good job!");
            Console.WriteLine($"{steps - TheGoal} steps over the goal!");

         }
         else
         {
            Console.WriteLine($"{TheGoal - steps} more steps to reach goal.");

         }

      }
   }
}
