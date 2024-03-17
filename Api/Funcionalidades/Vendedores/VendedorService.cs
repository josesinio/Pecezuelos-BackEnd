using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Vendedores;

public interface IVendedorService{
    void CreateVendedor(VendedorDto vendedorDto);

    List<Vendedor> GetVendedores();
}
public class VendedorService: IVendedorService
{
    public readonly PecezuelosDbContext context;
    public VendedorService(PecezuelosDbContext context)
    {
        this.context= context;
    }

    public void CreateVendedor(VendedorDto vendedorDto)
    {
        context.Vendedores.Add(new Vendedor(vendedorDto.ID , vendedorDto.Nombre, vendedorDto.Email, vendedorDto.Contraseña));
    }


    public List<Vendedor> GetVendedores()
    {
        return context.Vendedores.ToList();
    }

}
