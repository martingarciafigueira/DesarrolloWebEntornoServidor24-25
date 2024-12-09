using System.ComponentModel.DataAnnotations;

namespace Actividad3.Models
{
    public class Futbolista
    {
        public string codigo { get; set; }
        [StringLength(255)] public string nombre { get; set; }
        public string codigoEquipo { get; set; }
        public string posicion { get; set; }
        [Required] public int edad { get; set; }
        public int goles { get; set; }
        public int TA { get; set; }
        public int TR { get; set; }

        public int minutos { get; set; }
        public string precioMercado { get; set; }
        public int dorsal { get; set; }
        public int peso { get; set; }
    }
}
