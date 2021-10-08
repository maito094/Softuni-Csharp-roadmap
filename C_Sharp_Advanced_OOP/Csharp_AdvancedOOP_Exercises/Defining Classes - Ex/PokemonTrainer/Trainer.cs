using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class Trainer
   {
      public Trainer()
      {

      }
      public Trainer(string name)
      {
         Name = name;
         PokemonCollection = new List<Pokemon>();
         NumberOfBadges = 0;
      }

      public string Name { get; set; }
      public int NumberOfBadges { get; set; }
      public List<Pokemon> PokemonCollection { get; set; }

      public void AddPokemonToCollection(string name, string element, int health)
      {
         Pokemon newPokemon = new Pokemon(name, element, health);
         PokemonCollection.Add(newPokemon);
      }
   }
}
