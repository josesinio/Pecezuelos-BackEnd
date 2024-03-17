using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Clientes;

public interface IClienteService{
    List<Cliente> GetClientes();
    void CreateCliente(ClienteDto clienteDto);
}
public class ClienteService : IClienteService
{
    public readonly PecezuelosDbContext context;

    public ClienteService(PecezuelosDbContext context)
    {
        this.context= context;
    }

    public void CreateCliente(ClienteDto clienteDto)
    {
        context.Clientes.Add(new Cliente(clienteDto.ID, clienteDto.Nombre, clienteDto.Email, clienteDto.Contraseña));
        context.SaveChanges();
    }


    public List<Cliente> GetClientes()
    {
        return context.Clientes.ToList();
    }

}
