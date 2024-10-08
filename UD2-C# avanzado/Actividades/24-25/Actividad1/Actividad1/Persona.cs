using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    public class Persona
    {
        //Atributos de la clase
        public string nombre;
        public string apellidos;
        public int edad;
        public string genero;
        public string direccion;
        public string email;

        //Metodos de la clase

        public string Presentarse()
        {
            return $"hola, soy {nombre} {apellidos}";
        }

        public void EnviarCorreo(string mensaje)
        {
            Console.WriteLine("El correo dice que:");
            Console.WriteLine(mensaje);
        }

        public bool EsMayorDeEdad()
        {
            if (edad >= 18)
            {
                return true;
            }
            return false;
        }

    }
}
