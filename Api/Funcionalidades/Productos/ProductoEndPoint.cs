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
        app.MapPost("/Api/Producto/{IDproducto}/Comentario/{IDcomentario}", ([FromServices] IProductoService carritoServicio, Guid IDproducto, Guid IDcomentario)=>
        {
            carritoServicio.AddComentarioFromProducto(IDproducto,IDcomentario);
            return Results.Ok("Se agrego un comentario al producto con exito");
        });
        app.MapPut("/Api/Producto/{IDProducto}", ([FromServices] IProductoService productoServicio, ProductoDto productoDto, Guid IDProducto)=>
        {
            productoServicio.UpdateProducto(productoDto, IDProducto);
            return Results.Ok("Producto modificado con exito");
        });
        app.MapDelete("/Api/Producto/{IDProducto}", ([FromServices] IProductoService productoServicio, Guid IDProducto)=>
        {
            productoServicio.DeleteProducto(IDProducto);
            return Results.Ok("Producto eliminado con exito");
        });
        app.MapDelete("/Api/Producto/{IDproducto}/Comentario/{IDcomentario}", ([FromServices] IProductoService carritoServicio, Guid IDproducto, Guid IDcomentario)=>
        {
            carritoServicio.RemoveComentarioFromProducto(IDproducto,IDcomentario);
            return Results.Ok("Se Eliminio un producto al carrito con exito");
        });
    }

}
