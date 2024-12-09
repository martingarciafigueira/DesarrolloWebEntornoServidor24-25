using Actividad3.Models;
using Actividad3.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Actividad3.Controllers
{
    public class FutbolistaController : Controller
    {
        private readonly IFutbolistaRepository _repository;

        public FutbolistaController(IFutbolistaRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return RedirectToAction("GetAll");
        }
        public IActionResult GetAll()
        {
            List<Futbolista> listaFutbolista = new List<Futbolista>();
            listaFutbolista = (List<Futbolista>)_repository.GetFutbolistas();
            return View(listaFutbolista);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Futbolista Futbolista)
        {
            _repository.CreateFutbolista(Futbolista);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string codigo)
        {
            Futbolista Futbolista = _repository.GetFutbolistaById(codigo);

            return View(Futbolista);
        }
		[HttpPost]
		public IActionResult Edit(Futbolista Futbolista)
		{
            _repository.UpdateFutbolista(Futbolista);

			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult Delete(string codigo)
		{
            Futbolista Futbolista = _repository.GetFutbolistaById(codigo);

			return View(Futbolista);
		}
		[HttpPost]
		public IActionResult Delete(Futbolista Futbolista)
		{
			_repository.DeleteFutbolista(Futbolista);

			return RedirectToAction("Index");
		}
	}
}
