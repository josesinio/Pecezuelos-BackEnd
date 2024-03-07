using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Vendedores;

public  class VendedorEndPoint: ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
                app.MapGet("/Api/vendedor", ([FromServices] IVendedorService vendedorService)=>{
            return Results.Ok(vendedorService.GetVendedores());
        });
    }
}
