using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Clientes;

public  class ClienteEndPoint: ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/Api/Cliente", ([FromServices] IClienteService clienteService)=>
        {
            return Results.Ok(clienteService.GetClientes());
        }
        );
        app.MapPost("/Api/Cliente", ([FromServices] IClienteService clienteService, ClienteDto clienteDto)=>
        {
            clienteService.CreateCliente(clienteDto);
            return Results.Ok("Cleinte creado con exito");
        }
        );
    }

}
