using Actividad1.Models;
using Actividad2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class PokemonController : Controller
    {
        private readonly PokemonContext _contexto;

        public PokemonController(PokemonContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var manager = new PokemonManager(_contexto);
            var pokemons = manager.GetAllPokemon();
            return View(pokemons);
        }
        public ActionResult Info(int id)
        {
            var manager = new PokemonManager(_contexto);
            var pokemon = manager.GetPokemonByID(id);
            return View(pokemon);
        }
        public IActionResult GetPokemons(double peso, double altura)
        {
            var manager = new PokemonManager(_contexto);
            var pokemons = manager.GetPokemonByPesoAltura(peso, altura);
            return View(pokemons);
        }
        public IActionResult VerPokemon(int PokemonId, string nombre, float peso, float altura)
        {
            Pokemon pkmn = new Pokemon();
            pkmn.PokemonId = PokemonId;
            pkmn.nombre = nombre;
            pkmn.peso = peso;
            pkmn.altura = altura;

            return View(pkmn);
        }
    }
}
