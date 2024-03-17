using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Carritos;


public interface ICarritoService{
    List<Carrito> GetCarritos();
    void CreateCarrito(CarritoDto carritoDto);
    void DeleteCarrito(Guid IDcarrito);

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

    public List<Carrito> GetCarritos()
    {
        return context.Carritos.ToList();
    }


}
