using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
	public abstract class Articulo
    {
        private string titulo;
        private string precio;

		public Articulo(string titulo, string precio)
		{
			this.Titulo = titulo;
			this.Precio = precio;
		}

		public string Titulo { get => titulo; set => titulo = value; }
		public string Precio { get => precio; set => precio = value; }

		private void MostrarArticulo()
		{
			Console.WriteLine(titulo);
		}
	}
}
