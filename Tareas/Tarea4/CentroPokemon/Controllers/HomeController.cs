using CentroPokemon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CentroPokemon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Privacy", new { codigo = 56, nombre = "Enrique" });
            return View();
        }

        public IActionResult Privacy(int id, string nombre)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}