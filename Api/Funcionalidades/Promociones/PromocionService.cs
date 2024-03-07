using Aplicacion.Dominio;

namespace Api.Funcionalidades.Promociones;


public interface IPromocionService{
    List<Promocion> GetPromociones();
}
public class PromocionService: IPromocionService
{
    List<Promocion> promociones;

    public PromocionService()
    {
        promociones = new List<Promocion>(){
            new Promocion(1,"Descuento de pascuas", "Este descuento se atribuye gracias a que estamos en la celebridad de pascuas", 10, DateTime.Today , DateTime.Now.AddHours(1))
        };
    }

    public List<Promocion> GetPromociones()
    {
        return promociones;
    }

}
