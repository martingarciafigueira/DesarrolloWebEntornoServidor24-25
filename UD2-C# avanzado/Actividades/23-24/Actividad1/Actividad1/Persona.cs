using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
	public class Persona
	{
		private string nombre;
		private string apellidos;
		private int edad;
		private string genero;
		private string direccion;
		private string email;

		public string Nombre { get => nombre; set => nombre = value; }
		public string Apellidos { get => apellidos; set => apellidos = value; }
		public int Edad { get => edad; set => edad = value; }
		public string Genero { get => genero; set => genero = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public string Email { get => email; set => email = value; }

		public Persona(string nombre, string apellidos)
		{
			this.Nombre = nombre;
			this.Apellidos = apellidos;
		}

		public Persona(string direccion, int edad)
		{
			this.Direccion = direccion;
			this.Edad = edad;
		}

		public Persona(string nombre, string apellidos, int edad, string genero, string direccion, string email) : this(nombre, apellidos)
		{
			this.Edad = edad;
			this.Genero = genero;
			this.Direccion = direccion;
			this.Email = email;
		}

		public Persona()
		{
		}

		public string Presentarse()
		{
			return "Mi nombre es: " + Nombre;
		}

		public void EnviarCorreo(string mensaje)
		{
			Console.WriteLine("Se envía al mail " + Email + " el siguiente mensaje: " + mensaje);
		}

		public bool EsMayorDeEdad()
		{
			if (Edad >=18)
			{
				return true;
			}
			return false;
		}
	}
}
