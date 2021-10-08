using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
   {
      public static void Main(string[] args)
      {

         Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

         while (true)
         {
            string[] line = Console.ReadLine().Split();

            if (line[0] == "Tournament")
            {
               break;
            }

            string trainerName = line[0];
            string pokemonName = line[1];
            string pokemonElement = line[2];
            int pokemonHealth = int.Parse(line[3]);

            if (!trainers.ContainsKey(trainerName))
            {
               Trainer newTrainer = new Trainer(trainerName);
               trainers.Add(trainerName, newTrainer);
            }

            trainers[trainerName].AddPokemonToCollection(pokemonName, pokemonElement, pokemonHealth);

         }

         while (true)
         {
            string element = Console.ReadLine();

            if (element == "End")
            {
               break;
            }

            foreach (var trainer in trainers.Values)
            {
               if (trainer.PokemonCollection.Any(x => x.Element == element))
               {
                  trainer.NumberOfBadges++;
               }

               else
               {
                  for (int i = 0; i < trainer.PokemonCollection.Count; i++)
                  {
                     trainer.PokemonCollection[i].Health -= 10;

                     if (trainer.PokemonCollection[i].Health <= 0)
                     {
                        trainer.PokemonCollection.RemoveAt(i);
                        i--;
                     }
                  }

               }

            }

         }

         List<Trainer> sortedTrainers = trainers.Values.OrderByDescending(o => o.NumberOfBadges).ToList();

         foreach (var trainer in sortedTrainers)
         {
            Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.PokemonCollection.Count}");
         }

      }
   }
}
