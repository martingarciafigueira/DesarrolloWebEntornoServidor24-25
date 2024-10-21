﻿using Actividad1.Models;
using System.Xml.Linq;

namespace Actividad2.Models
{
    public class PokemonManager : IDisposable
    {
        private readonly PokemonContext _context;

        public PokemonManager(PokemonContext context)
        {
            _context = context;
        }

        public IEnumerable<Pokemon> GetAllPokemon()
        {
            var pokemons = from pokemon in _context.Pokemon
                   select pokemon;
            return pokemons;
        }

        public Pokemon GetPokemonByID(int id)
        {
            return (Pokemon)_context.Pokemon.FirstOrDefault(pokemon => pokemon.PokemonId == id);
        }

        public IEnumerable<Pokemon> GetPokemonByPesoAltura(double peso, double altura)
        {
            var pokemons = from p in _context.Pokemon
                          where p.altura == altura && p.peso == peso
                          select p;
            return pokemons.ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
