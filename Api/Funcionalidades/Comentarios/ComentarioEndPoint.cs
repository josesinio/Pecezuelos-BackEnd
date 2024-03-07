using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Comentarios;

public  class ComentarioEndPoint: ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
                app.MapGet("/Api/Comentario", ([FromServices] IComentarioService comentarioService)=>{
            return Results.Ok(comentarioService.GetComentarios());
        });
    }

}
