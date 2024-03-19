using Api.Funcionalidades.Comentarios;
using Api.Persistencia;
using Aplicacion.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Api.Funcionalidades.Productos;
public interface IProductoService
{
    void AddComentarioFromProducto(Guid dproducto, Guid dcomentario);

    void CreateProducto(ProductoDto productoDt);
    void DeleteProducto(Guid IDProducto);

    List<ProductoQueryDto> GetProductos();
    void RemoveComentarioFromProducto(Guid dproducto, Guid dcomentario);

    void UpdateProducto(ProductoDto productoDto, Guid IDProducto);

}
public class ProductoService : IProductoService
{
    public readonly PecezuelosDbContext context;

    public ProductoService(PecezuelosDbContext context)
    {
        this.context =context;
    }

    public void AddComentarioFromProducto(Guid dproducto, Guid dcomentario)
    {
        var Producto = context.Productos.FirstOrDefault(x=> x.ID == dproducto);
        var Comentario = context.Comentarios.FirstOrDefault(x=> x.IdComentario == dcomentario);

        if(Producto != null ! && Comentario != null)
        {
            Producto.AgregarComentario(Comentario);
            context.SaveChanges();
        }
    }


    public void CreateProducto(ProductoDto productoDto)
    {
        context.Productos.Add(new Producto(new Guid(), productoDto.Nombre, productoDto.IDVendedor, productoDto.Precio, productoDto.RutaImagen, productoDto.Categoria, productoDto.Stock, productoDto.Descripcion));
        context.SaveChanges();
    }

    public void DeleteProducto(Guid IDProducto)
    {
        var producto = context.Productos.FirstOrDefault(x => x.ID == IDProducto);

        if (producto != null)
        {
            context.Remove(producto);

            context.SaveChanges();
        }
    }


    public List<ProductoQueryDto> GetProductos()
    {
        return context.Productos
        .Include(x=> x.Comentarios)
        .Select(x=> new ProductoQueryDto
        {
            Nombre = x.Nombre,
            Precio = x.Precio,
            RutaImagen = x.RutaImagen,
            Categoria = x.Categoria,
            Descripcion = x.Descripcion,
            Comentarios = x.Comentarios.Select( y => new ComentarioQueryDto{
            Mensaje = y.Mensaje,
            Valoracion = y.Valoracion
            }).ToList()
        }).ToList();
    }

    public void RemoveComentarioFromProducto(Guid dproducto, Guid dcomentario)
    {
        var Producto = context.Productos.FirstOrDefault(x=> x.ID == dproducto);
        var comentario = context.Comentarios.FirstOrDefault(x=> x.IdComentario == dcomentario);

        if(Producto != null ! && comentario != null)
        {
            Producto.EliminarComentario(comentario);
            context.SaveChanges();
        }
    }


    public void UpdateProducto(ProductoDto productoDto, Guid IDProducto)
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
