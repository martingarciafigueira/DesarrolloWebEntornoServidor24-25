using System.ComponentModel.DataAnnotations;

namespace Actividad1.Models
{
    public class EquipoMetadata
    {
        [Required, Range(0, int.MaxValue)] public string codigo { get; set; }
        [Required, StringLength(50)] public string nombre { get; set; }
        [Required, StringLength(50)] public string pais { get; set; }
        [Required, Range(0, int.MaxValue)] public int goles { get; set; }
        [Required, Range(0, int.MaxValue)] public int puntos{ get; set; }
        [Required, StringLength(50)] public string pj{ get; set; }
        [Required, Range(0, int.MaxValue)] public int pg { get; set; }
        [Required, Range(0, int.MaxValue)] public int pe { get; set; }
        [Required, Range(0, int.MaxValue)] public int pp { get; set; }
        [Required, StringLength(50)] public string estadio { get; set; }
        [Required, StringLength(50)] public string ciudad { get; set; }
    }
}
