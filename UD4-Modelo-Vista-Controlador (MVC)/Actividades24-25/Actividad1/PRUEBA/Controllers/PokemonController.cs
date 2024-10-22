using Microsoft.AspNetCore.Mvc;
using PRUEBA.Models;

namespace PRUEBA.Controllers
{
    public class PokemonController : Controller
    {
        //Añado las dos acciones
        public IActionResult Agregar()
        {
            return View();
        }
        public IActionResult VerPokemon()
        {
            Pokemon p1 = new Pokemon();
            p1.PokemonId = 1;
            p1.Nombre = "Pikachu";
            p1.Altura = 0.5f;
            p1.Peso = 5;

            return View(p1);
        }
    }
}
