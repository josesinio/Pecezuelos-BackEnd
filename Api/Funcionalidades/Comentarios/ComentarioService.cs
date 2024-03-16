using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Comentarios;


public interface IComentarioService{
    List<Comentario> GetComentarios();
}
public class ComentarioService: IComentarioService
{
    public readonly PecezuelosDbContext context;
    public ComentarioService(PecezuelosDbContext context)
    {
        this.context = context;
    }

    public List<Comentario> GetComentarios()
    {
        return context.Comentarios.ToList();
    }

}
