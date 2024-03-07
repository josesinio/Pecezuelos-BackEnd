using System.Net.Http.Headers;
using Aplicacion.Dominio;
using Microsoft.VisualBasic;

namespace Api.Funcionalidades.Carritos;


public interface ICarritoService{
    List<Carrito> GetCarritos();
}
public class CarritoService : ICarritoService
{
    List<Carrito> carritos;

    public CarritoService()
    {
        carritos= new List<Carrito>(){
            new Carrito(1,1, 202020)
        };
    }
    public List<Carrito> GetCarritos()
    {
        return carritos;
    }
}
