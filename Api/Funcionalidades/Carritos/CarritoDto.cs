using Api.Funcionalidades.Productos;

namespace Api.Funcionalidades.Carritos;

public class CarritoDto
{
    public required Guid IDCarrito {get; set;}
    public required Guid IDCliente {get; set;}
}
public class CarritoQueryDto
{
    public  Guid IDCarrito {get; set;}
    public  Guid IDCliente {get; set;}
    public List<ProductoQueryDto> Productos {get; set;} = new List<ProductoQueryDto>();
}
