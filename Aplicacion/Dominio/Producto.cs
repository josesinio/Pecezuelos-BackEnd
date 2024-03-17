using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;

[Table("Producto")]
public class Producto: EntidadConNombre
{
    [ForeignKey("IdVendedor")]
    [Required]
    public Guid IDVendedor {get; set;}
    [Required]
    public int Precio {get; set;}

    public string RutaImagen {get; set;}
    [Required]
    public Categoria Categoria {get; set;}
    [Required]
    public int Stock {get; set;}
    [Required]
    public List<Promocion> Promociones {get; set;}
    [Required]
    public string Descripcion {get; set;}
    public List<Comentario> Comentarios {get; set;}

    public Producto(Guid ID,string Nombre, Guid IDVendedor, int Precio, string RutaImagen, Categoria Categoria, int Stock, string Descripcion) : base(ID ,Nombre)
    {
        this.IDVendedor= IDVendedor;
        this.Precio= Precio;
        this.RutaImagen = RutaImagen;
        this.Categoria = Categoria;
        this.Stock = Stock;
        this.Descripcion= Descripcion;
        Comentarios= new List<Comentario>();
        Promociones= new List<Promocion>();
    }
    //public void GuardarImagen(IFormFile imagen)
//{
    //var rutaImagen = Path.Combine("ruta/donde/guardar/imagenes", imagen.FileName);
    //using (var stream = new FileStream(rutaImagen, FileMode.Create))
    //{
    //    imagen.CopyTo(stream);
    //}
    //this.RutaImagen = rutaImagen;
//}


}