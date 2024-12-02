﻿using Actividad1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registro(Usuario usuario)
        {
            return Content("Guarda el usuario en base de datos");
        }
        public IActionResult InicioSesion(Usuario usuario)
        {
            return Content("Comprueba si el usuario existe en base de datos");
        }
        [Route("Usuario/Perfil/{nombre:length(3,20)}")]
        public IActionResult Perfil(string nombre)
        {
            return Content($"Muestra la sesion del usuario {nombre}");
        }
    }
}
