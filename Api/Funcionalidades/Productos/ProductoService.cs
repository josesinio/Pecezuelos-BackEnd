using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Productos;

public interface IProductoService{
    List<Producto> GetProductos();
}
public class ProductoService : IProductoService
{
    public readonly PecezuelosDbContext context;

    public ProductoService(PecezuelosDbContext context)
    {
        this.context = context;
    }
    public List<Producto> GetProductos()
    {
        return context.Productos.ToList();
    }

}
