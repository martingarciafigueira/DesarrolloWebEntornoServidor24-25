namespace Actividad4.Models
{
    public class Pedido
    {
        string cliente;
        string direccion;
        string ciudad;
        Producto producto;

        public string Cliente { get => cliente; set => cliente = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public Producto Producto { get => producto; set => producto = value; }
    }
}
