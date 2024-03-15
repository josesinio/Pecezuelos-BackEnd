using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;

[Table("Carrito")]
public class Carrito
{
    [Key]
    [Required]
    public byte IDCarrito { get; set; }

    [ForeignKey("IdCliente")]
    [Required]
    public byte IDCliente { get; set; }

    [Required]
    public int PrecioTotal { get; set; }

    public List<Producto> Productos { get; set; }


    public Carrito(byte IDCarrito,byte IDCliente, int PrecioTotal)
    {
        this.IDCarrito =IDCarrito;
        this.IDCliente= IDCliente;
        this.PrecioTotal = PrecioTotal;
        Productos = new List<Producto>();
    }

}
