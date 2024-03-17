using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Promociones;

public class PromocionEndPoints: ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/Api/Promocion", ( [FromServices] IPromocionService promocionService)=>
        {
            return Results.Ok(promocionService.GetPromociones());
        });
        
        app.MapPost("/Api/Promocion", ([FromServices] IPromocionService promocionService, PromocionDto promocionDto)=>{
            promocionService.CreatePromocion(promocionDto);
            return Results.Ok("Promoción creada con éxito");
        });
    }
}
