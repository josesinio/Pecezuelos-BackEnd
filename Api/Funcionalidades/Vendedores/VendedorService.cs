using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Vendedores;

public interface IVendedorService{
    void CreateVendedor(VendedorDto vendedorDto);
    void DeleteVendedor(byte IDVendedor);
    List<Vendedor> GetVendedores();
    void UpdateVendedor(byte IDVendedor, VendedorDto vendedorDto);

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

    public void DeleteVendedor(byte IDVendedor)
    {
        var vendedor = context.Vendedores.FirstOrDefault(x => x.ID == IDVendedor);
        
        if(vendedor != null){
            context.Vendedores.Remove(vendedor);
            context.SaveChanges();

        }
    }

    public List<Vendedor> GetVendedores()
    {
        return context.Vendedores.ToList();
    }

    public void UpdateVendedor(byte IDVendedor, VendedorDto vendedorDto)
    {
        var vendedor = context.Vendedores.FirstOrDefault(x => x.ID == IDVendedor);
        
        if(vendedor != null){
            
            vendedor.Nombre = vendedorDto.Nombre;
            vendedor.Email = vendedorDto.Email;
            vendedor.Contraseña = vendedorDto.Contraseña;

            context.SaveChanges();
        }
    }
}
