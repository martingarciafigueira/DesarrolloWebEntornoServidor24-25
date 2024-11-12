using Dapper;

namespace Actividad2B.Models.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly Conexion _conexion;

        public PokemonRepository(Conexion conexion){
            _conexion = conexion;
        }

        public IEnumerable<Pokemon> GetPokemons()
        {
            var query = "SELECT * FROM Pokemon";

            using (var connection = _conexion.ObtenerConexion())
            {
                var pokemons =  connection.Query<Pokemon>(query);
                return pokemons;
            }
        }
    }
}
