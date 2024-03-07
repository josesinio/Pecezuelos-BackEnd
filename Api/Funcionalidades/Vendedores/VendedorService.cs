using Aplicacion.Dominio;

namespace Api.Funcionalidades.Vendedores;

public interface IVendedorService{
    List<Vendedor> GetVendedores();
}
public class VendedorService: IVendedorService
{
    List<Vendedor> vendedores;
    public VendedorService()
    {
        vendedores= new List<Vendedor>{
            new Vendedor(1,"Jose", "Jose","Josesito")
        };
    }

    public List<Vendedor> GetVendedores()
    {
        return vendedores;
    }

}
