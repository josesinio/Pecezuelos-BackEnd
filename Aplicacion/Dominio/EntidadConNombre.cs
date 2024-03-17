using System.ComponentModel.DataAnnotations;

namespace Aplicacion.Dominio;

public abstract class  EntidadConNombre
{
    [Key]
    [Required]
    public Guid ID {get; set;}

    [StringLength(50)]
    [Required]
    public string Nombre {get; set;}

    public EntidadConNombre(Guid ID,string Nombre){
        this.ID = ID;
        this.Nombre = Nombre;
    }

    public void CambiarNombre(string NuevoNombre){
        Nombre = NuevoNombre;
    }
}
