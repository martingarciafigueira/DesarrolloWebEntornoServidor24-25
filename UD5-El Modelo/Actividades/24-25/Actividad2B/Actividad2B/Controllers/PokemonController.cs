using Actividad2B.Models;
using Actividad2B.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2B.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _repository;

        public PokemonController(IPokemonRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return RedirectToAction("GetAll");
        }

        public IActionResult GetAll()
        {
            List<Pokemon> listaPokemon = new List<Pokemon>();
            listaPokemon = (List<Pokemon>)_repository.GetPokemons();
            return View(listaPokemon);
        }
    }
}
