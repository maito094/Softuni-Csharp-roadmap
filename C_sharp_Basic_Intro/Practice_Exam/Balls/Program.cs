using System;

namespace Balls
{
   class Program
   {
      static void Main(string[] args)
      {
         int numBalls = int.Parse(Console.ReadLine());
         int i = 0;
         string colors = string.Empty;
         int redPoints = 0;
         int orangePoints = 0;
         int yellowPoints = 0;
         int whitePoints = 0;
         int blackPoints = 0;
         int otherColorsPicked = 0;
         int allPoints = 0;

         while (i < numBalls)
         {
            colors = Console.ReadLine();

            switch (colors)
            {
            case "red":
               redPoints += 5;
               allPoints += 5;
               break;
            case "orange":
               orangePoints += 10;
               allPoints += 10;
               break;
            case "yellow":
               yellowPoints += 15;
               allPoints += 15;
               break;
            case "white":
               whitePoints += 20;
               allPoints += 20;
               break;
            case "black":
               allPoints = Convert.ToInt16(Math.Floor(allPoints * 1.0 / 2));
               blackPoints++;
               break;

            default:
               otherColorsPicked++;
               break;

            }
            i++;
         }
         Console.WriteLine($"Total points: {allPoints}");
         Console.WriteLine($"Points from red balls: {redPoints / 5}");
         Console.WriteLine($"Points from orange balls: {orangePoints / 10}");
         Console.WriteLine($"Points from yellow balls: {yellowPoints / 15}");
         Console.WriteLine($"Points from white balls: {whitePoints / 20}");
         Console.WriteLine($"Other colors picked: {otherColorsPicked}");
         Console.WriteLine($"Divides from black balls: {blackPoints}");
      }
   }
}
