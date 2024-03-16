using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Vendedores;

public interface IVendedorService{
    List<Vendedor> GetVendedores();
}
public class VendedorService: IVendedorService
{
    public readonly PecezuelosDbContext context;
    public VendedorService(PecezuelosDbContext context)
    {
        this.context= context;
    }

    public List<Vendedor> GetVendedores()
    {
        return context.Vendedores.ToList();
    }

}
