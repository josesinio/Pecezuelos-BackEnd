using Aplicacion.Dominio;

namespace Api.Funcionalidades.Comentarios;


public interface IComentarioService{
    List<Comentario> GetComentarios();
}
public class ComentarioService: IComentarioService
{
    List<Comentario> comentarios;
    public ComentarioService()
    {
        comentarios= new List<Comentario>(){
            new Comentario(1,1,"Jose crack", Valoracion.MuyBueno)
        };
    }

    public List<Comentario> GetComentarios()
    {
        return comentarios;
    }

}
