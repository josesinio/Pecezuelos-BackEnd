using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Promociones;

public interface IPromocionService{
    void CreatePromocion(PromocionDto promocionDto);

    List<Promocion> GetPromociones();
}
public class PromocionService: IPromocionService
{
    public readonly PecezuelosDbContext context;

    public PromocionService(PecezuelosDbContext context)
    {
        this.context= context;
    }

    public void CreatePromocion(PromocionDto promocionDto)
    {
        context.Promociones.Add(new Promocion(promocionDto.ID, promocionDto.Nombre, promocionDto.Descripcion, promocionDto.Descuento, promocionDto.FechaInicio, promocionDto.FechaFin));
        context.SaveChanges();
    }


    public List<Promocion> GetPromociones()
    {
        return context.Promociones.ToList();
    }



}
