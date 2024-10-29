using Microsoft.EntityFrameworkCore;

namespace PRUEBA.Models.Context
{
    public class PokemonContext : DbContext
    {
        public PokemonContext(DbContextOptions<PokemonContext> options) : base(options) { }
        public DbSet<Pokemon> Pokemon { get; set; }
    }
}
