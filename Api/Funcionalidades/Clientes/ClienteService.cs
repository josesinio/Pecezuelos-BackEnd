using Api.Funcionalidades.Carritos;
using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Clientes;

public interface IClienteService{
    List<Cliente> GetClientes();
    void CreateCliente(ClienteDto clienteDto);
    void DeleteCliente(Guid IDcliente);
    void UpdateCliente(Guid IDcliente, ClienteDto clienteDtoDto);
    void CreateCarrito(Carrito carritoCliente);
    void DeleteCarrito(Guid dcliente);

}
public class ClienteService : IClienteService
{
    public readonly PecezuelosDbContext context;

    public ClienteService(PecezuelosDbContext context)
    {
        this.context= context;
    }

    public void CreateCarrito(Carrito carritoCliente)
    {
        context.Carritos.Add(carritoCliente);
        context.SaveChanges();
    }


    public void CreateCliente(ClienteDto clienteDto)
    {
        
        context.Clientes.Add(new Cliente(clienteDto.ID, clienteDto.Nombre, clienteDto.Email, clienteDto.Contraseña));
    
        context.SaveChanges();
    }

    public void DeleteCarrito(Guid dcliente)
    {
        var carrito = context.Carritos.FirstOrDefault(x=> x.IDCliente == dcliente);
        if (carrito != null){
            context.Carritos.Remove(carrito);
            context.SaveChanges();
        }
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
