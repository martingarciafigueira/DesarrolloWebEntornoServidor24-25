using Actividad6.Models;
using Actividad6.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using System.Text;
using System.Text.Json;

namespace Actividad6.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProductoRepository _repository;

        public List<Producto> GetListaProductosSesion()
        {
            List<Producto> carrito = new List<Producto>();
            if (HttpContext.Session.Get("CARRITO") != null)
            {
                string jsonString = Encoding.UTF8.GetString(HttpContext.Session.Get("CARRITO"));
                carrito = JsonSerializer.Deserialize<List<Producto>>(jsonString);
            }
            return carrito;
        }

        public ProductoController(IProductoRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return RedirectToAction("ListarProductos");
        }

        public IActionResult ListarProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            listaProductos = (List<Producto>)_repository.GetProductos();
            return View(listaProductos);
        }

        public IActionResult MostrarProductosSesion()
        {
            return View(GetListaProductosSesion());
        }
        public IActionResult AgregarProductoSesion(int id)
        {
            Producto productoObtenido = _repository.GetProductoById(id);

            List<Producto> carrito = GetListaProductosSesion();
            carrito.Add(productoObtenido);
            string jsonString = JsonSerializer.Serialize(carrito);
            HttpContext.Session.Set("CARRITO", Encoding.UTF8.GetBytes(jsonString));

            return RedirectToAction("ListarProductos");
        }
        public IActionResult DeleteProductoSesion(int id)
        {
            List<Producto> carrito = GetListaProductosSesion();
            var producto = carrito.FirstOrDefault(p => p.Codigo == id);
            carrito.Remove(producto);

            string jsonString = JsonSerializer.Serialize(carrito);
            HttpContext.Session.Set("CARRITO", Encoding.UTF8.GetBytes(jsonString));

            return RedirectToAction("MostrarProductosSesion");
        }
    }
}
