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
        app.MapPost("/Api/Carrito/{IDCarrito}/Producto/{IDProducto}", ([FromServices] ICarritoService carritoServicio, Guid IDCarrito, Guid IDProducto)=>
        {
            carritoServicio.AddProductoFromCarrito(IDCarrito,IDProducto);
            return Results.Ok("Se agrego un producto al carrito con exito");
        });
        app.MapDelete("/Api/Carrito/{IDcarrito}", ([FromServices] ICarritoService carritoService, Guid IDcarrito)=>{
            carritoService.DeleteCarrito(IDcarrito);
            return Results.Ok("Carrito Eliminada con éxito");
        });
        app.MapDelete("/Api/Carrito/{IDCarrito}/Producto/{IDProducto}", ([FromServices] ICarritoService carritoServicio, Guid IDCarrito, Guid IDProducto)=>
        {
            carritoServicio.RemoveProductoFromCarrito(IDCarrito,IDProducto);
            return Results.Ok("Se Eliminio un producto al carrito con exito");
        });
    }

}
