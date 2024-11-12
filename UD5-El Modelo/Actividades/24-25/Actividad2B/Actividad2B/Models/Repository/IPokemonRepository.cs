namespace Actividad2B.Models.Repository
{
    public interface IPokemonRepository
    {
        IEnumerable<Pokemon> GetPokemons();
    }
}
