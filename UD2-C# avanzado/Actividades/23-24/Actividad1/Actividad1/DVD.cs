using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
	class DVD: Articulo
    {
        private int duracion;

		public DVD(string titulo, string precio, int duracion) : base(titulo, precio)
		{
			this.duracion = duracion;
		}
	}
}
