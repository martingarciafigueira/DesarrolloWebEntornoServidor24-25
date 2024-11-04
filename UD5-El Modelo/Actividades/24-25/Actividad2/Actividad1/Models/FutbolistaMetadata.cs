using System.ComponentModel.DataAnnotations;

namespace Actividad1.Models
{
    public class FutbolistaMetadata
    {
        [Required, StringLength(50)] public string codigo { get; set; }
        [Required, StringLength(50)] public string nombre { get; set; }
        [Required, Range(0, int.MaxValue)] public int codigoEquipo { get; set; }
        [Required, StringLength(50)] public string posicion { get; set; }
        [Required, Range(0,100)] public int edad { get; set; }
        [Required, Range(0, int.MaxValue)] public int goles { get; set; }
        [Required, Range(0, int.MaxValue)] public int TA { get; set; }
        [Required, Range(0, int.MaxValue)] public int TR { get; set; }
        [Required, Range(0, int.MaxValue)] public int minutos { get; set; }
        [Required, StringLength(50)] public string precioMercado { get; set; }
        [Required, Range(0, int.MaxValue)] public int dorsal { get; set; }
        [Required, Range(0, int.MaxValue)] public int peso { get; set; }
    }
}
