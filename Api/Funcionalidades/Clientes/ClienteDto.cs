namespace Api.Funcionalidades.Clientes;

public class ClienteDto
{
    public required byte ID {get; set;}
    public required string Nombre {get; set;}
    public required string Email {get; set;}
    public required string Contraseña {get; set;}
}
