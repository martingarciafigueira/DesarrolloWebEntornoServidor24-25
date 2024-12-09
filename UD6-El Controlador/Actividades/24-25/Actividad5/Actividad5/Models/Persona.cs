namespace Actividad5.Models
{
    public class Persona
    {
        string nombre;
        string apellidos;
        string dni;
        int edad;
        string lugarNacimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public string LugarNacimiento { get => lugarNacimiento; set => lugarNacimiento = value; }
    }
}
