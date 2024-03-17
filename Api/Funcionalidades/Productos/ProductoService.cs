using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Productos;
public interface IProductoService
{
    void CreateProducto(ProductoDto productoDt);
    void DeleteProducto(byte IDProducto);

    List<Producto> GetProductos();
    void UpdateProducto(ProductoDto productoDto, byte IDProducto);

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

    public void DeleteProducto(byte IDProducto)
    {
        var producto = context.Productos.FirstOrDefault(x => x.ID == IDProducto);

        if (producto != null)
        {
            context.Remove(producto);

            context.SaveChanges();
        }
    }


    public List<Producto> GetProductos()
    {
        return context.Productos.ToList();
    }

    public void UpdateProducto(ProductoDto productoDto, byte IDProducto)
    {
        var producto = context.Productos.FirstOrDefault(x => x.ID == IDProducto );
        if(producto != null){

            producto.Nombre = productoDto.Nombre;
            producto.Precio = productoDto.Precio;
            producto.Descripcion = productoDto.Descripcion;            
            producto.Stock = productoDto.Stock;
            producto.RutaImagen = productoDto.RutaImagen;

            context.SaveChanges();
        }
    }
}
