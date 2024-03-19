using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;
[Table("Cliente")]

public class Cliente : Usuario
{
    public virtual Carrito? Carrito{get; set;}= null;
    public Cliente( Guid ID,string Nombre, string Email, string Contraseña) : base(ID, Nombre, Email, Contraseña)
    {
    }

}
