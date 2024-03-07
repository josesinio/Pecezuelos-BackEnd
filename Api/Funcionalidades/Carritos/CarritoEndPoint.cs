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
    }

}