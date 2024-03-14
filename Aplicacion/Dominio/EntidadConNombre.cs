using System.ComponentModel.DataAnnotations;

namespace Aplicacion.Dominio;

public abstract class  EntidadConNombre
{
    [Key]
    [Required]
    public byte ID {get; set;}

    [StringLength(50)]
    [Required]
    public string Nombre {get; set;}

    public EntidadConNombre(byte ID,string Nombre){
        this.ID = ID;
        this.Nombre = Nombre;
    }

    public void CambiarNombre(string NuevoNombre){
        Nombre = NuevoNombre;
    }
}
