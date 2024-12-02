using Actividad1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
	public class ProductoController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Agregar(Producto producto)
		{
			if (producto.Id == 0 && producto.Nombre == null && producto.Precio == 0)
			{
				return View();
			}
			//Agrego el producto a la BD
			return RedirectToAction("Index");
		}

        public IActionResult Editar(int id, Producto producto)
		{
			if (id == 0)
			{
                return RedirectToAction("Index");
            }
			else if (producto == null)
			{
				return View();
			}

            //Actualizo el producto en BBDD
            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }

            //Borra el producto en BBDD
            return RedirectToAction("Index");
        }


        [Route("Listar/{categoria?}/{marca?}")]
		public IActionResult Listar(string categoria, string marca)
		{
			return Content("Muestro una lista de productos");
		}
		[Route("producto/detalles/{id:int:length(4)}-{slug:alpha}")]
		public IActionResult Detalles(int id, string slug)
		{
			return Content($"Muestro los detalles del producto con ID: {id} y slug: {slug}");
		}
		[Route("Producto/Buscar/{terminoBusqueda?}")]
		public IActionResult Buscar(string terminoBusqueda)
		{
			if (terminoBusqueda == null)
			{
				return RedirectToAction("Index");
			}

			return Content($"{terminoBusqueda}");
		}
	}
}
