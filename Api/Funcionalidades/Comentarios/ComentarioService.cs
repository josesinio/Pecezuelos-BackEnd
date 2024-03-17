using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Comentarios;


public interface IComentarioService{
    List<Comentario> GetComentarios();
    void CreateComentario(ComentarioDto comentarioDto);
}
public class ComentarioService: IComentarioService
{
    public readonly PecezuelosDbContext context;
    public ComentarioService(PecezuelosDbContext context)
    {
        this.context = context;
    }

    public void CreateComentario(ComentarioDto comentarioDto)
    {
        context.Comentarios.Add(new Comentario(comentarioDto.IDComentario, comentarioDto.IDCliente, comentarioDto.Mensaje, comentarioDto.Valoracion));
    }


    public List<Comentario> GetComentarios()
    {
        return context.Comentarios.ToList();
    }

}
