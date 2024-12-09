namespace Actividad6.Models.Repository
{
    public interface IProductoRepository
    {
        IEnumerable<Producto> GetProductos();
        Producto GetProductoById(int codigo);
    }
}
