using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Productos;

public  class ProductoEndPoint: ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/Api/Producto", ([FromServices] IProductoService productoServicio)=>
        {
            return Results.Ok(productoServicio.GetProductos());
        });
        app.MapPost("/Api/Producto", ([FromServices] IProductoService productoServicio, ProductoDto productoDto)=>
        {
            productoServicio.CreateProducto(productoDto);
            return Results.Ok("Producto creado con exito");
        });
    }

}
