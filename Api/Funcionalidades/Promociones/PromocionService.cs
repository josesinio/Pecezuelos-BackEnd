using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Promociones;

public interface IPromocionService{
    void CreatePromocion(PromocionDto promocionDto);
    void DeletePromocion(Guid IDPromocion);
    List<Promocion> GetPromociones();
    void UpdatePromocion(Guid IDPromocion, PromocionDto promocionDto);

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
        context.Promociones.Add(new Promocion(new Guid(), promocionDto.Nombre, promocionDto.Descripcion, promocionDto.Descuento, promocionDto.FechaInicio, promocionDto.FechaFin));
        context.SaveChanges();
    }

    public void DeletePromocion(Guid IDPromocion)
    {
        var promocion = context.Promociones.FirstOrDefault(x => x.ID == IDPromocion);

        if (promocion != null)
        {
            context.Remove(promocion);

            context.SaveChanges();
        }
    }

    public List<Promocion> GetPromociones()
    {
        return context.Promociones.ToList();
    }

    public void UpdatePromocion(Guid IDPromocion, PromocionDto promocionDto)
    {
        var promocion = context.Promociones.FirstOrDefault(x => x.ID == IDPromocion );
        if(promocion != null){

            promocion.Nombre = promocionDto.Nombre;
            promocion.Descripcion = promocionDto.Descripcion;
            promocion.Descuento = promocionDto.Descuento;
            promocion.FechaInicio = promocionDto.FechaInicio;
            promocion.FechaFin = promocionDto.FechaFin;

            context.SaveChanges();
        }
    }

}
