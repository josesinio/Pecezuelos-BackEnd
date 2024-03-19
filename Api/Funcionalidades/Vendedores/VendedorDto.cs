using Api.Funcionalidades.Productos;

namespace Api.Funcionalidades.Vendedores;

public class VendedorDto
{
    public required string Nombre {get; set;}
    public required string Email {get; set;}
    public required string Contraseña {get; set;}
}

public class VendedorQueryDto
{
    public  Guid ID {get; set;}
    public  string Nombre {get; set;} = string.Empty;
    public string Email {get; set;} = string.Empty;
    public List<ProductoQueryDto> Productos {get; set;} = new List<ProductoQueryDto>();
}