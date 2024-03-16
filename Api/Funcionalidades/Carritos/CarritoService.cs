using System.Net.Http.Headers;
using Api.Persistencia;
using Aplicacion.Dominio;
using Microsoft.VisualBasic;

namespace Api.Funcionalidades.Carritos;


public interface ICarritoService{
    List<Carrito> GetCarritos();
}
public class CarritoService : ICarritoService
{
    public readonly PecezuelosDbContext context;

    public CarritoService(PecezuelosDbContext context)
    {
        this.context = context;
    }
    public List<Carrito> GetCarritos()
    {
        return context.Carritos.ToList();
    }
}
