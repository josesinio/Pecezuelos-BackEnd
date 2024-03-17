using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;
[Table("Vendedor")]
public class Vendedor : Usuario
{
    public List<Producto> Productos {get; set;}
    public Vendedor(Guid ID , string Nombre, string Email, string Contraseña) : base(ID, Nombre, Email, Contraseña)
    {
        Productos = new List<Producto>();
    }

}
