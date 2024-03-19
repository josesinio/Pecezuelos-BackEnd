using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;

[Table("Carrito")]
public class Carrito
{
    [Key]
    [Required]
    public Guid IDCarrito { get; set; }

    [ForeignKey("IdCliente")]
    [Required]
    public Guid IDCliente { get; set; }

    [Required]
    public int PrecioTotal { get; set; }

    public List<Producto> Productos { get; set; }


    public Carrito(Guid IDCarrito,Guid IDCliente)
    {
        this.IDCarrito =IDCarrito;
        this.IDCliente= IDCliente;
        PrecioTotal = 0;
        Productos = new List<Producto>();
    }

    public void AgregarProducto(Producto producto) => Productos.Add(producto);

    public void EliminarProducto(Producto producto) => Productos.Remove(producto);

}
