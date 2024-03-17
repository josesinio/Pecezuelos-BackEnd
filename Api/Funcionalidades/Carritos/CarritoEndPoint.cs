using Api.Funcionalidades.Carritos;
using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Productos;

public class CarritoEndPoint: ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app){
        app.MapGet("/Api/Carrito", ([FromServices] ICarritoService carritoServicio)=>
        {
            return Results.Ok(carritoServicio.GetCarritos());
        });
        app.MapPost("/Api/Carrito", ([FromServices] ICarritoService carritoServicio, CarritoDto carritoDto)=>
        {
            carritoServicio.CreateCarrito(carritoDto);
            return Results.Ok("Carrito creado con exito");
        });
        app.MapDelete("/Api/Carrito/{IDcarrito}", ([FromServices] ICarritoService carritoService, byte IDcarrito)=>{
            carritoService.DeleteCarrito(IDcarrito);
            return Results.Ok("Carrito Eliminada con éxito");
        });
    }

}
