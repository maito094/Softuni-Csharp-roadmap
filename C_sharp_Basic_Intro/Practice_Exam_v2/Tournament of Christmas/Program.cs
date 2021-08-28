using System;

namespace Tournament_of_Christmas
{
   class Program
   {
      static void Main(string[] args)
      {
         int daysTournament = int.Parse(Console.ReadLine());
         string cmd = "";
         string outcome = "";
         double moneyWon = 0;
         double moneyWonDaily = 0;
         int gameWon = 0;
         int gameLoose = 0;

         int tournamentWon = 0;
         for (int i = 1; i <= daysTournament; i++)
         {
            gameWon = 0;
            gameLoose = 0;
            cmd = Console.ReadLine();
            while (cmd != "Finish")
            {
               outcome = Console.ReadLine();
               if (outcome == "win")
               {
                  gameWon++;
                  moneyWon += 20;
               }
               else
               {
                  gameLoose++;
               }
               cmd = Console.ReadLine();

            }

            if (gameWon > gameLoose)
            {
               moneyWon = moneyWon * 1.10;
               tournamentWon++;
            }
            else
            {
               tournamentWon--;
            }
            moneyWonDaily += moneyWon;
            moneyWon = 0;

         }
         if (tournamentWon > 0)
         {
            moneyWonDaily = moneyWonDaily * 1.20;
            Console.WriteLine($"You won the tournament! Total raised money: {moneyWonDaily:f2}");
         }
         else
         {
            Console.WriteLine($"You lost the tournament! Total raised money: {moneyWonDaily:f2}");

         }
      }
   }
}
