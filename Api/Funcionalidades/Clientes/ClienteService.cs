using Aplicacion.Dominio;

namespace Api.Funcionalidades.Clientes;


public interface IClienteService{
    List<Cliente> GetClientes();
}
public class ClienteService : IClienteService
{
    List<Cliente> clientes;

    public ClienteService()
    {
        clientes= new List<Cliente>(){
            
            new Cliente(1, "Josesito", "Josesito@gmail.com","Josesito123",1)
        };
    }
    public List<Cliente> GetClientes()
    {
        return clientes;
    }

}
