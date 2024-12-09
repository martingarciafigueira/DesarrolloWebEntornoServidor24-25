namespace Actividad6.Models
{
    public class Producto
    {
        int codigo;
        string nombre;
        double precio;
        int codigo_fabricante;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Codigo_fabricante { get => codigo_fabricante; set => codigo_fabricante = value; }
    }
}
