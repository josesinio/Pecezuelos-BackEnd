using System.Runtime.CompilerServices;
using Api.Funcionalidades.Productos;
using Api.Persistencia;
using Aplicacion.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Api.Funcionalidades.Carritos;


public interface ICarritoService{
    List<CarritoQueryDto> GetCarritos();
    void CreateCarrito(CarritoDto carritoDto);
    void DeleteCarrito(Guid IDcarrito);
    void AddProductoFromCarrito(Guid IDCarrito, Guid IDProducto);
    void RemoveProductoFromCarrito(Guid iDCarrito, Guid iDProducto);

}
public class CarritoService : ICarritoService
{
    public readonly PecezuelosDbContext context;

    public CarritoService(PecezuelosDbContext context)
    {
        this.context = context;
    }

    public void AddProductoFromCarrito(Guid IDCarrito, Guid IDProducto)
    {
        var Producto = context.Productos.FirstOrDefault(x=> x.ID == IDProducto);
        var carrito = context.Carritos.FirstOrDefault(x=> x.IDCarrito == IDCarrito);

        if(Producto != null ! && carrito != null)
        {
            carrito.AgregarProducto(Producto);
            context.SaveChanges();
        }

    }


    public void CreateCarrito(CarritoDto carritoDto)
    {
        context.Carritos.Add(new Carrito(new Guid(), carritoDto.IDCliente));
        context.SaveChanges();
    }

    public void DeleteCarrito(Guid IDcarrito)
    {
        var carrito = context.Carritos.FirstOrDefault(x => x.IDCarrito == IDcarrito);

        if (carrito != null)
        {
            context.Remove(carrito);

            context.SaveChanges();
        }
    }

    public void RemoveProductoFromCarrito(Guid iDCarrito, Guid iDProducto)
    {
        var Producto = context.Productos.FirstOrDefault(x=> x.ID == iDProducto);
        var carrito = context.Carritos.FirstOrDefault(x=> x.IDCarrito == iDCarrito);

        if(Producto != null ! && carrito != null)
        {
            carrito.EliminarProducto(Producto);
            context.SaveChanges();
        }
    }


    public List<CarritoQueryDto> GetCarritos()
    {
        return context.Carritos
        .Include(x=> x.Productos )
        .Select(x=> new CarritoQueryDto
        { 
            IDCarrito = x.IDCarrito,
            IDCliente = x.IDCliente,
            Productos = x.Productos.Select(y=> new ProductoQueryDto {
            Nombre= y.Nombre,
            Precio= y.Precio,
            RutaImagen = y.RutaImagen,
            Categoria = y.Categoria,
            Descripcion = y.Descripcion}).ToList()
            }).ToList();
    }


}
