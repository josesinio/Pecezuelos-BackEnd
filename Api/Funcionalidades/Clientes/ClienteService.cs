using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Clientes;

public interface IClienteService{
    List<Cliente> GetClientes();
}
public class ClienteService : IClienteService
{
    public readonly PecezuelosDbContext context;

    public ClienteService(PecezuelosDbContext context)
    {
        this.context= context;
    }
    public List<Cliente> GetClientes()
    {
        return context.Clientes.ToList();
    }

}
