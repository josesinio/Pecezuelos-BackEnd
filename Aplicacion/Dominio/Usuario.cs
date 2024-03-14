using System.ComponentModel.DataAnnotations;

namespace Aplicacion.Dominio;

public abstract class Usuario: EntidadConNombre
{
    [Required]
    [StringLength(50)]
    public string Email {get; set;}
    [Required]
    [StringLength(50)]
    public string Contraseña {get; set;}
    protected Usuario(byte ID, string Nombre,string Email, string Contraseña ) : base(ID, Nombre)
    {
        this.Email= Email;
        this.Contraseña= Contraseña;
    }

}
