using Aplicacion.Dominio;

namespace Api.Funcionalidades.Comentarios;

public class ComentarioDto
{
    public required Guid IDCliente {get; set;}
    public required string Mensaje {get; set;}
    public required Valoracion Valoracion {get; set;}

}
