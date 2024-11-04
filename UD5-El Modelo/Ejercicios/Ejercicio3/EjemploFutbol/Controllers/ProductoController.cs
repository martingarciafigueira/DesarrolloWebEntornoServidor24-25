﻿using EjemploFutbol.Models.Repositories;
using Ejercicio1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio3.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public async Task<IActionResult> Index()
        {
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Data = await _productoRepository.GetProductos();
            return View("Index", Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetById(int codigo)
        {
            var producto = await _productoRepository.GetProducto(codigo);
            return View("VerProducto", producto);
        }
    }
}
