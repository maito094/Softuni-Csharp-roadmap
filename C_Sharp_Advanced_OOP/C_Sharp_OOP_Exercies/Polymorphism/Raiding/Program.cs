using System;
using System.Collections.Generic;

namespace Raiding
{
   class Program
   {
      static void Main(string[] args)
      {
         List<string> heroTypes = new List<string> { "Druid", "Paladin", "Rogue", "Warrior" };

         List<BaseHero> heroes = new List<BaseHero>();

         int n = int.Parse(Console.ReadLine());

         while (true)
         {

            if (heroes.Count == n)
            {
               break;
            }

            string heroName = Console.ReadLine();
            string heroType = Console.ReadLine();

            BaseHero hero = null;

            int heroTypeIndex = heroTypes.IndexOf(heroType);

            if (heroTypeIndex == -1)
            {
               Console.WriteLine("Invalid hero!");
               continue;
            }

            if (heroTypeIndex == 0)
            {
               hero = new Druid(heroName);
            }
            else if (heroTypeIndex == 1)
            {
               hero = new Paladin(heroName);
            }
            else if (heroTypeIndex == 2)
            {
               hero = new Rogue(heroName);
            }
            else if (heroTypeIndex == 3)
            {
               hero = new Warrior(heroName);
            }

            heroes.Add(hero);

         }

         int bossPower = int.Parse(Console.ReadLine());

         int heroesCollectivePower = 0;

         foreach (var hero in heroes)
         {
            Console.WriteLine(hero.CastAbility());
            heroesCollectivePower += hero.Power;
         }

         if (heroesCollectivePower >= bossPower)
         {
            Console.WriteLine("Victory!");
         }
         else
         {
            Console.WriteLine("Defeat...");
         }

      }
   }
}
