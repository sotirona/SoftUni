using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PokemonTrainer
{
    public class PokemonTrainer
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var trainers = new List<Trainer>();
            var pokemons = new List<Pokemon>();

            while (input != "Tournament")
            {
                var trainerInfo = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                var trainerName = trainerInfo[0];
                var pokemonName = trainerInfo[1];
                var pokemonElement = trainerInfo[2];
                var pokemonHealth = int.Parse(trainerInfo[3]);

                var currPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                pokemons.Add(currPokemon);

                if (!trainers.Any(t => t.Name == trainerName))
                {
                    var trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }

                var currentTraniner = trainers.FirstOrDefault(t => t.Name == trainerName);

                if (!currentTraniner.Pokemons.Any(p => p.Name == pokemonName))
                {
                    var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    currentTraniner.Pokemons.Add(pokemon);
                }
                else
                {
                    currentTraniner.Pokemons.FirstOrDefault(p => p.Name == pokemonName).Element = pokemonElement;
                    currentTraniner.Pokemons.FirstOrDefault(p => p.Name == pokemonName).Health += pokemonHealth;
                }

                input = Console.ReadLine();
            }

            var element = Console.ReadLine();

            while (!element.Equals("End"))
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    var currentTrainer = trainers[i];
                    if (currentTrainer.Pokemons.Any(p => p.Element.Equals(element)))
                    {
                        currentTrainer.NumberOfBadges++;
                    }
                    else
                    {
                        currentTrainer.Pokemons.ForEach(p => p.Health -= 10);
                        for (int j = 0; j < currentTrainer.Pokemons.Count; j++)
                        {
                            if (currentTrainer.Pokemons[j].Health <= 0)
                            {
                                currentTrainer.Pokemons.RemoveAt(j);
                                j--;
                            }
                        }
                    }
                }

                element = Console.ReadLine();

            }

            trainers = trainers.OrderByDescending(t => t.NumberOfBadges).ToList();

            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
