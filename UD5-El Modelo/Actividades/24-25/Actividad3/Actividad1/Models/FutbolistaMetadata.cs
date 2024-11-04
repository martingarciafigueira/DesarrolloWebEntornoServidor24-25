using System.ComponentModel.DataAnnotations;

namespace Actividad1.Models
{
    public class FutbolistaMetadata : IValidatableObject
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int codigoEquipo { get; set; }
        public string posicion { get; set; }
        public int edad { get; set; }
        public int goles { get; set; }
        public int TA { get; set; }
        public int TR { get; set; }
        public int minutos { get; set; }
        public string precioMercado { get; set; }
        public int dorsal { get; set; }
        public int peso { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> validationResults = new List<ValidationResult>();

            if (codigoEquipo == null) validationResults.Add(new ValidationResult("El codigo equipo no puede ser nulo"));

            if (edad >= 45) validationResults.Add(new ValidationResult("Es demasiado mayor, retírese"));
            
            if (minutos <= 0) validationResults.Add(new ValidationResult("Ya está retirado, no tiene minutos"));

            if (dorsal < 1 || dorsal > 25) validationResults.Add(new ValidationResult("No pertenece a la primera plantilla"));

            if (string.IsNullOrEmpty(precioMercado)) validationResults.Add(new ValidationResult("No tiene valor"));

            return validationResults;

        }
    }
}
