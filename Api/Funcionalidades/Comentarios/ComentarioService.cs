using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Comentarios;


public interface IComentarioService{
    List<Comentario> GetComentarios();
    void CreateComentario(ComentarioDto comentarioDto);
    void DeleteComentario(byte IDcomentario);
    void UpdateComentario(byte IDcomentario, ComentarioDto comentarioDto);
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

    public void DeleteComentario(byte IDcomentario)
    {
        var comentario = context.Comentarios.FirstOrDefault(x => x.IdComentario == IDcomentario);

        if (comentario != null)
        {
            context.Remove(comentario);

            context.SaveChanges();
        }
    }

    public List<Comentario> GetComentarios()
    {
        return context.Comentarios.ToList();
    }

    public void UpdateComentario(byte IDcomentario, ComentarioDto comentarioDto)
    {
        var comentario = context.Comentarios.FirstOrDefault(x => x.IdComentario == IDcomentario );
        if(comentario != null){

            comentario.Mensaje = comentarioDto.Mensaje;
            comentario.Valoracion = comentarioDto.Valoracion;
            context.SaveChanges();
        }
    }
}
