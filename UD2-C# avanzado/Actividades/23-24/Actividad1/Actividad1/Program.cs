using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Persona profe1 = new Persona();
			Persona profe2 = new Persona();
			Persona profe3 = new Persona();

			Console.WriteLine(profe1.Email);
			profe1.Email = "NUEVO";

			profe1.EnviarCorreo("Correo 1");

			//Actividad 3

			Libro libro1 = new Libro("HP", "Caro", "JK Rowling");
			DVD peli1 = new DVD("HP peli", "Barata", 128);

			Articulo pelicula;
			pelicula = new DVD("ESDLA", "CARO", 222);

			CensuraDeArticulos(peli1);
			CensuraDeArticulos(libro1);

			Console.ReadKey();
		}

		public static void CensuraDeArticulos(Articulo art)
		{
			Console.WriteLine("Este articulo merece ser censurado");
		}
	}
}
