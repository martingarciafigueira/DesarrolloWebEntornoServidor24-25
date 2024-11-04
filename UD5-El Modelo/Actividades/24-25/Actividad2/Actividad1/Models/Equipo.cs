using System.ComponentModel.DataAnnotations;

namespace Actividad1.Models
{
    [MetadataType(typeof(EquipoMetadata))]
    public class Equipo
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string pais { get; set; }
        public int goles { get; set; }
        public int puntos{ get; set; }
        public string pj{ get; set; }
        public int pg { get; set; }
        public int pe { get; set; }
        public int pp { get; set; }
        public string estadio { get; set; }
        public string ciudad { get; set; }
    }
}
