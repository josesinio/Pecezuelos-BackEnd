namespace Api.Funcionalidades.Clientes;

public class ClienteDto
{
    public required Guid ID = Guid.NewGuid();
    public required string Nombre {get; set;}
    public required string Email {get; set;}
    public required string Contraseña {get; set;}
}
