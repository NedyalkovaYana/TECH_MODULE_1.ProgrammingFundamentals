using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Pokemon_Evolution
{
    class Program
    {
        class PokemonEvolution
        {
           
            public string EvolutionType { get; set; }
            public int EvolutionIndex { get; set; }
        }

        static void Main(string[] args)
        {

            Dictionary<string, List<PokemonEvolution>> pokemons = new Dictionary<string, List<PokemonEvolution>>();

            while (true)
            {
                var input = Console.ReadLine().Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string pokemonName = input[0];
                if (input[0] == "wubbalubbadubdub")
                {
                    break;
                }

                if (input.Length > 1)
                {
                    pokemonName = input[0];
                    string pokemonType = input[1];
                    int pokemonIndex = int.Parse(input[2]);


                    PokemonEvolution pokemon = new PokemonEvolution
                    {                      
                        EvolutionType = pokemonType,
                        EvolutionIndex = pokemonIndex
                    };

                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons.Add(pokemonName, new List<PokemonEvolution>());
                    }
                    pokemons[pokemonName].Add(pokemon);
                }
                else
                {
                    if (pokemons.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");

                        foreach (var item in pokemons[pokemonName])
                        {
                            Console.WriteLine($"{item.EvolutionType} <-> {item.EvolutionIndex}");
                        }
                    }
                }
            }
            foreach (var pokey in pokemons)
            {
                Console.WriteLine($"# {pokey.Key}");
                foreach (var item in pokey.Value.OrderByDescending(a => a.EvolutionIndex))
                {
                    Console.WriteLine($"{item.EvolutionType} <-> {item.EvolutionIndex}");
                }
            }
           
        }
    }
}
