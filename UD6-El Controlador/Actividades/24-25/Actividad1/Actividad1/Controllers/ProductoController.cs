using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
	public class ProductoController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Listar()
		{
			return Content("Muestro una lista de productos");
		}
		public IActionResult Detalles(int id)
		{
			return Content("Muestro los detalles del producto con ID: " + id);
		}
		public IActionResult Buscar(string nombre)
		{
			return Content("Busco productos que tengan este nombre: " + nombre);
		}
	}
}
