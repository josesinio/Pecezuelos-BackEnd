using Api.Funcionalidades.Carritos;
using Aplicacion.Dominio;
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
            var CarritoCliente= new Carrito( new Guid(),clienteDto.ID);
            clienteService.CreateCarrito(CarritoCliente);
            return Results.Ok("Cliente creado con exito");
        }
        );
        app.MapPut("/Api/Cliente/{IDcliente}", ([FromServices] IClienteService clienteService, ClienteDto clienteDto, Guid IDcliente)=>{
            clienteService.UpdateCliente(IDcliente, clienteDto);
            return Results.Ok("Cliente Modificado con éxito");
        });
        app.MapDelete("/Api/Cliente/{IDcliente}", ([FromServices] IClienteService clienteService, Guid IDcliente)=>{
            clienteService.DeleteCliente(IDcliente);
            clienteService.DeleteCarrito(IDcliente);
            return Results.Ok("Cliente Eliminado con éxito");
        });

    }

}
