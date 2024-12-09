using Actividad4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad4.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CrearPedido()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearPedido(Pedido pedido)
        {
            return View();
        }

    }
}
