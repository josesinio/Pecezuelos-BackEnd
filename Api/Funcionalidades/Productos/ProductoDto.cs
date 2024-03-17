using Aplicacion.Dominio;

namespace Api.Funcionalidades.Productos;

public class ProductoDto
{
    public required byte ID{get; set;}
    public required string   Nombre {get; set;}
    public required byte IDVendedor {get; set;}
    public required int Precio{get; set;}
    public required string RutaImagen {get; set;}
    public required Categoria Categoria {get; set;}
    public required int Stock {get; set;}
    public required string Descripcion {get; set; }
}