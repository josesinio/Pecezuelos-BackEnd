using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;

[Table("Producto")]
public class Producto: EntidadConNombre
{
    [ForeignKey("IdVendedor")]
    [Required]
    public byte IDVendedor {get; set;}
    [Required]
    public int Precio {get; set;}

    public string Imagen {get; set;}
    [Required]
    public Categoria Categoria {get; set;}
    [Required]
    public int Stock {get; set;}
    [Required]
    public List<Promocion> Promociones {get; set;}
    [Required]
    public string Descripcion {get; set;}
    public List<Comentario> Comentarios {get; set;}

    public Producto(byte ID,string Nombre, byte IDVendedor, int Precio, string Imagen, Categoria Categoria, int Stock, string Descripcion) : base(ID ,Nombre)
    {
        this.IDVendedor= IDVendedor;
        this.Precio= Precio;
        this.Imagen = Imagen;
        this.Categoria = Categoria;
        this.Stock = Stock;
        this.Descripcion= Descripcion;
        Comentarios= new List<Comentario>();
        Promociones= new List<Promocion>();
    }


}