using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Comentarios;


public interface IComentarioService{
    List<Comentario> GetComentarios();
    void CreateComentario(ComentarioDto comentarioDto);
    void DeleteComentario(Guid IDcomentario);
    void UpdateComentario(Guid IDcomentario, ComentarioDto comentarioDto);
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
        context.Comentarios.Add(new Comentario(new Guid(), comentarioDto.IDCliente, comentarioDto.Mensaje, comentarioDto.Valoracion));
        context.SaveChanges();
    }

    public void DeleteComentario(Guid IDcomentario)
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

    public void UpdateComentario(Guid IDcomentario, ComentarioDto comentarioDto)
    {
        var comentario = context.Comentarios.FirstOrDefault(x => x.IdComentario == IDcomentario );
        if(comentario != null){

            comentario.Mensaje = comentarioDto.Mensaje;
            comentario.Valoracion = comentarioDto.Valoracion;
            context.SaveChanges();
        }
    }
}
