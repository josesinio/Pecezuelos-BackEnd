using Api.Funcionalidades.Comentarios;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Productos;

public class ProductoDto
{

    public required string   Nombre {get; set;}
    public required Guid IDVendedor {get; set;}
    public required int Precio{get; set;}
    public required string RutaImagen {get; set;}
    public required Categoria Categoria {get; set;}
    public required int Stock {get; set;}
    public required string Descripcion {get; set; }
}

public class ProductoQueryDto
{

    public  string Nombre {get; set;} = string.Empty;
    public  int Precio{get; set;}
    public  string RutaImagen {get; set;}= string.Empty;
    public  Categoria Categoria {get; set;}
    public  string Descripcion {get; set; }= string.Empty;
    public List<ComentarioQueryDto> Comentarios {get; set;} = new List<ComentarioQueryDto>();
}

