﻿using System.ComponentModel.DataAnnotations;

namespace Actividad1.Models
{
    [MetadataType(typeof(FutbolistaMetadata))]
    public class Futbolista
    {
        public string codigo { get; set; }
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
    }
}
