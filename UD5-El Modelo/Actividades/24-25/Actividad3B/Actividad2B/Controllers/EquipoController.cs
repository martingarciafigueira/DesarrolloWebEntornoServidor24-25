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
        [HttpGet]
        public IActionResult Edit(string codigo)
        {
            Equipo equipo = _repository.GetEquipoById(codigo);

            return View(equipo);
        }
		[HttpPost]
		public IActionResult Edit(Equipo equipo)
		{
            _repository.UpdateEquipo(equipo);

			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult Delete(string codigo)
		{
			Equipo equipo = _repository.GetEquipoById(codigo);

			return View(equipo);
		}
		[HttpPost]
		public IActionResult Delete(Equipo equipo)
		{
			_repository.DeleteEquipo(equipo);

			return RedirectToAction("Index");
		}
	}
}
