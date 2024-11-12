using Actividad3.Models;
using Actividad3.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Actividad3.Controllers
{
    public class EquipoController : Controller
    {
        private readonly IEquipoRepository _repository;

        public EquipoController(IEquipoRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return RedirectToAction("GetAll");
        }
        public IActionResult GetAll()
        {
            List<Equipo> listaEquipo = new List<Equipo>();
            listaEquipo = (List<Equipo>)_repository.GetEquipos();
            return View(listaEquipo);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Equipo equipo)
        {
            _repository.CreateEquipo(equipo);
            return RedirectToAction("Index");
        }
    }
}
