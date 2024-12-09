using Dapper;

namespace Actividad6.Models.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly Conexion _conexion;

        public ProductoRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public Producto GetProductoById(int codigo)
        {
            var query = $"SELECT * FROM producto WHERE codigo = {codigo}";
            using (var connection = _conexion.ObtenerConexion())
            {
                var producto = connection.QueryFirst<Producto>(query);
                return (Producto)producto;
            }
        }

        public IEnumerable<Producto> GetProductos()
        {
            var query = "SELECT * FROM producto";
            using (var connection = _conexion.ObtenerConexion())
            {
                var productos = connection.Query<Producto>(query);
                return productos;
            }
        }
    }
}
