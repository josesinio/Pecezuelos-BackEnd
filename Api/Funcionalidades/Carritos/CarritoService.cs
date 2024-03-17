using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Carritos;


public interface ICarritoService{
    List<Carrito> GetCarritos();
    void CreateCarrito(CarritoDto carritoDto);
}
public class CarritoService : ICarritoService
{
    public readonly PecezuelosDbContext context;

    public CarritoService(PecezuelosDbContext context)
    {
        this.context = context;
    }

    public void CreateCarrito(CarritoDto carritoDto)
    {
        context.Carritos.Add(new Carrito(carritoDto.IDCarrito, carritoDto.IDCliente));
        context.SaveChanges();
    }


    public List<Carrito> GetCarritos()
    {
        return context.Carritos.ToList();
    }
}
