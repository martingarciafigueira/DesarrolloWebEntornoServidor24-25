using Actividad5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad5.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CambiarNombreApellidosOld(string nombre, string apellidos, string dni, int edad, string lugarNacimiento)
        {
            Persona p1 = new Persona();
            p1.Nombre = nombre;
            p1.Apellidos = apellidos;
            p1.Dni = dni;
            p1.Edad = edad;
            p1.LugarNacimiento = lugarNacimiento;

            return View();
        }

        public IActionResult CambiarNombreApellidos([Bind("Nombre, Apellidos, Dni")]Persona p1)
        {
            return View();
        }

    }
}
