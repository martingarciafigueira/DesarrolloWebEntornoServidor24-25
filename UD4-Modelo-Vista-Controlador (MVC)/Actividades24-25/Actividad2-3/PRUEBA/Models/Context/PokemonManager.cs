namespace PRUEBA.Models.Context
{
    public class PokemonManager
    {
        private readonly PokemonContext _context;

        public PokemonManager(PokemonContext context)
        {
            _context = context;
        }

        public List<Pokemon> GetAllPokemons()
        {
            List<Pokemon> listaPokemons = new List<Pokemon>();

            var pokemons = from pokemon in _context.Pokemon
                           orderby pokemon.PokemonId
                           select pokemon;

            listaPokemons.AddRange(pokemons);

            return listaPokemons;
        }

        public Pokemon GetPokemonByID(int PokemonId)
        {
            var pokemons = from pokemon in _context.Pokemon
                           where pokemon.PokemonId == PokemonId
                           orderby pokemon.PokemonId
                           select pokemon;

            return (Pokemon) pokemons.FirstOrDefault();
        }

        public List<Pokemon> GetPokemonsByPesoAltura(float peso, float altura)
        {
            List<Pokemon> listaPokemons = new List<Pokemon>();

            var pokemons = from pokemon in _context.Pokemon
                           where pokemon.Peso == peso && pokemon.Altura == altura
                           orderby pokemon.PokemonId
                           select pokemon;

            listaPokemons.AddRange(pokemons);

            return listaPokemons;
        }

    }
}
