using Microsoft.AspNetCore.Mvc;
using PRUEBA.Models;
using PRUEBA.Models.Context;

namespace PRUEBA.Controllers
{
    public class PokemonController : Controller
    {
        private readonly PokemonContext _contexto;

        public PokemonController(PokemonContext contexto)
        {
            _contexto = contexto;
        }
        //Añado las dos acciones
        public IActionResult Index()
        {
            return View();
        }
        //Añado las dos acciones
        public IActionResult Agregar()
        {
            return View();
        }
        public IActionResult VerPokemon()
        {
            PokemonManager pkm = new PokemonManager(_contexto);

            return View(pkm.GetPokemonByID(48));
        }

        //Añadimos una lista para ver Pokemons
        public IActionResult VerListaPokemon()
        {
            PokemonManager pkm = new PokemonManager(_contexto);

            //return View(pkm.GetPokemonsByPesoAltura(4, 0.3f));
            return View(pkm.GetAllPokemons());
        }
    }
}
