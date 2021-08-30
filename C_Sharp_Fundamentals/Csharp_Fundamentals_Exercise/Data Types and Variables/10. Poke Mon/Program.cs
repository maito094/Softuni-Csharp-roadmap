using System;

namespace _10._Poke_Mon
{
   class Program
   {
      static void Main(string[] args)
      {
         int nPokePower = int.Parse(Console.ReadLine());
         int mDistanceTarget = int.Parse(Console.ReadLine());
         int yExhaustionFactor = int.Parse(Console.ReadLine());

         int countTargets = 0;
         int nSubstratcionPower = nPokePower;

         while (mDistanceTarget <= nSubstratcionPower)
         {
            nSubstratcionPower -= mDistanceTarget;
            countTargets++;
            if (nSubstratcionPower == (double)nPokePower * 0.5 && yExhaustionFactor > 0)
            {
               nSubstratcionPower /= yExhaustionFactor;
            }
         }
         Console.WriteLine(nSubstratcionPower);
         Console.WriteLine(countTargets);
      }
   }
}
