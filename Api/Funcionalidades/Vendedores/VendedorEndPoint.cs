using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Vendedores;

public  class VendedorEndPoint: ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/Api/Vendedor", ([FromServices] IVendedorService vendedorService)=>
        {
            return Results.Ok(vendedorService.GetVendedores());
        }
        );
        app.MapPost("/Api/Vendedor", ([FromServices] IVendedorService vendedorService, VendedorDto vendedorDto)=>
        {
            vendedorService.CreateVendedor(vendedorDto);
            return Results.Ok("Vendedor creado con exito");
        }
        );
    }
}
