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
        app.MapPut("/Api/Vendedor/{IDVendedor}", ([FromServices] IVendedorService vendedorService, VendedorDto vendedorDto, Guid IDVendedor)=>
        {
            vendedorService.UpdateVendedor(IDVendedor, vendedorDto);
            return Results.Ok("Vendedor modificado con exito");
        }
        );
        app.MapPost("/Api/Vendedor/{IDVendedor}", ([FromServices] IVendedorService vendedorService, Guid IDVendedor)=>
        {
            vendedorService.DeleteVendedor(IDVendedor);
            return Results.Ok("Vendedor Eliminado con exito");
        }
        );
    }
}
