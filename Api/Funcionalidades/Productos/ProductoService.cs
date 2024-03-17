using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Productos;
public interface IProductoService
{
    void CreateProducto(ProductoDto productoDto);
    List<Producto> GetProductos();
}
public class ProductoService : IProductoService
{
    public readonly PecezuelosDbContext context;

    public ProductoService(PecezuelosDbContext context)
    {
        this.context =context;
    }

    public void CreateProducto(ProductoDto productoDto)
    {
        context.Productos.Add(new Producto(productoDto.ID, productoDto.Nombre, productoDto.IDVendedor, productoDto.Precio, productoDto.RutaImagen, productoDto.Categoria, productoDto.Stock, productoDto.Descripcion));
        context.SaveChanges();
    }

    public List<Producto> GetProductos()
    {
        return context.Productos.ToList();
    }

}
