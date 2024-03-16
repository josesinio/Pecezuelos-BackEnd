using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Promociones;

public interface IPromocionService{
    List<Promocion> GetPromociones();
}
public class PromocionService: IPromocionService
{
    public readonly PecezuelosDbContext context;

    public PromocionService(PecezuelosDbContext context)
    {
        this.context= context;
    }
    public List<Promocion> GetPromociones()
    {
        return context.Promociones.ToList();
    }

}
