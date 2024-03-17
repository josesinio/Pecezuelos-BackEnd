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
        app.MapPost("/Api/Comentario", ([FromServices] IComentarioService comentarioService, ComentarioDto comentarioDto)=>{
            comentarioService.CreateComentario(comentarioDto);
            return Results.Ok("Comentario creado con exito");
        });
        app.MapPut("/Api/Comentario/{IDcomentario}", ([FromServices] IComentarioService comentarioService, ComentarioDto comentarioDto, Guid IDcomentario)=>{
            comentarioService.UpdateComentario(IDcomentario, comentarioDto);
            return Results.Ok("Comentario Modificado con éxito");
        });
        app.MapDelete("/Api/Comentario/{IDcomentario}", ([FromServices] IComentarioService comentarioService, Guid IDcomentario)=>{
            comentarioService.DeleteComentario(IDcomentario);
            return Results.Ok("Comentario Eliminado con éxito");
        });
    }

}
