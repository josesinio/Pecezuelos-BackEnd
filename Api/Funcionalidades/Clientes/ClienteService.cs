using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Clientes;

public interface IClienteService{
    List<Cliente> GetClientes();
    void CreateCliente(ClienteDto clienteDto);
    void DeleteCliente(Guid IDcliente);
    void UpdateCliente(Guid IDcliente, ClienteDto clienteDtoDto);
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
        context.Clientes.Add(new Cliente(new Guid(), clienteDto.Nombre, clienteDto.Email, clienteDto.Contraseña));
        context.SaveChanges();
    }

    public void DeleteCliente(Guid IDcliente)
    {
        var cliente = context.Clientes.FirstOrDefault(x => x.ID == IDcliente);

        if (cliente != null)
        {
            context.Remove(cliente);

            context.SaveChanges();
        }
    }

    public List<Cliente> GetClientes()
    {
        return context.Clientes.ToList();
    }

    public void UpdateCliente(Guid IDcliente, ClienteDto clienteDto)
    {
        var Cliente = context.Clientes.FirstOrDefault(x => x.ID == IDcliente );
        if(Cliente != null){

            Cliente.Nombre = clienteDto.Nombre;
            Cliente.Email = clienteDto.Email;
            Cliente.Contraseña = clienteDto.Contraseña;
            context.SaveChanges();
        }
    }
}
