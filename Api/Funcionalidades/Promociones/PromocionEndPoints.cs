using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Promociones;

public class PromocionEndPoints: ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
                app.MapGet("/Api/Promocion", ( [FromServices] IPromocionService promocionService)=>{
            return Results.Ok(promocionService.GetPromociones());
        });
    }
}
